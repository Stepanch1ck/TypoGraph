using System.Text.RegularExpressions;

namespace TypoGraph
{
    public partial class MainForm : Form
    {
        public string text;
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputrichTextBox_TextChanged(object sender, EventArgs e)
        {
            text = inputrichTextBox.Text;
            outbutrichTextBox.Text = ProcessText(text);

        }
        public string ProcessText(string text)
        {

            text = Regex.Replace(text, @"([.,!?;:])", " $1 ");
            text = Regex.Replace(text, @"(-\s+)", "Ч ");
            text = Regex.Replace(text, @"\s{2,}", " ");

            bool isOpenQuote = false;
            text = Regex.Replace(text, "\"", match =>
            {
                if (isOpenQuote)
                {
                    isOpenQuote = false;
                    return "ї";
                }
                else
                {
                    isOpenQuote = true;
                    return "Ђ";
                }
            });

            text = Regex.Replace(text, @"(?<year1>\d{4})-(?<year2>\d{4})", "$1Ч$2");
            text = Regex.Replace(text, @" - ", " Ч ");

            text = Regex.Replace(text, @"(?<=\w)\.(?=\w)", ". ");

            text = Regex.Replace(text, @"!", "!!");
            text = Regex.Replace(text, @"ха", "хахахахахахахахахаха");
            text = Regex.Replace(text, @"вх", "вхвхвхвхвхвхвхвхвхвх");

            return text.Trim();
        }
    }
}
