using System.Collections.Generic;
using System.Windows.Forms;

namespace sample
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();

            Dictionary<string, int> counts = null;
            Theme.Safely(() => counts = Database.GetStatusCounts());
            if (counts == null) counts = new Dictionary<string, int>();

            int total = 0;
            foreach (int v in counts.Values) total += v;

            lblTotal.Text = total.ToString();
            lblWorking.Text = Get(counts, "Working").ToString();
            lblDefective.Text = Get(counts, "Defective").ToString();
            lblRepair.Text = Get(counts, "Under Repair").ToString();
        }

        private static int Get(Dictionary<string, int> d, string key)
        {
            int v;
            return d.TryGetValue(key, out v) ? v : 0;
        }
    }
}