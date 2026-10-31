using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sample
{
    public partial class DashboardControl : UserControl
    {
        private readonly Panel[] cards;

        public DashboardControl()
        {
            InitializeComponent();

            cards = new[] { pnlTotal, pnlWorking, pnlDefective, pnlRepair };

            Dictionary<string, int> counts = null;
            Theme.Safely(() => counts = Database.GetStatusCounts());
            if (counts == null) counts = new Dictionary<string, int>();

            int total = 0;
            foreach (int v in counts.Values) total += v;

            lblTotal.Text = total.ToString();
            lblWorking.Text = Get(counts, "Working").ToString();
            lblDefective.Text = Get(counts, "Defective").ToString();
            lblRepair.Text = Get(counts, "Under Repair").ToString();

            Resize += (s, e) => LayoutCards();
            LayoutCards();
        }

        // Spreads the four cards evenly across the width of the screen
        private void LayoutCards()
        {
            const int top = 90;
            const int gap = 20;
            const int cardHeight = 130;

            int usable = ClientSize.Width - (gap * (cards.Length - 1));
            int cardWidth = usable / cards.Length;
            if (cardWidth < 120) cardWidth = 120;

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Location = new Point(i * (cardWidth + gap), top);
                cards[i].Size = new Size(cardWidth, cardHeight);
            }
        }

        private static int Get(Dictionary<string, int> d, string key)
        {
            int v;
            return d.TryGetValue(key, out v) ? v : 0;
        }
    }
}