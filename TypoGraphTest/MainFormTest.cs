using TypoGraph;
using Xunit;

namespace TypoGraphTest
{
    public class MainFormTest
    {
        private readonly MainForm _form;

        public MainFormTest()
        {
            _form = new MainForm();
        }

        [Fact]
        public void ProcessText_AddsSpacesAroundPunctuation()
        {
            const string input = "Привет,мир!Это тест.";
            const string expected = "Привет , мир ! Это тест .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesHyphensWithEmDash()
        {
            const string input = "Это тест - с дефисами.";
            const string expected = "Это тест — с дефисами .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_RemovesExtraSpaces()
        {
            const string input = "Это   строка     с   очень   большим     количеством      пробелов.";
            const string expected = "Это строка с очень большим количеством пробелов .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesQuotesWithChevrons()
        {
            const string input = "\"Это строка в кавычках\".";
            const string expected = "«Это строка в кавычках» .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesYearRangeWithEmDash()
        {
            const string input = "Это произошло в  2022-2023.";
            const string expected = "Это произошло в 2022—2023 .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesSpaceHyphenSpaceWithEmDash()
        {
            const string input = "Это диапазон - от 10 до 20.";
            const string expected = "Это диапазон — от 10 до 20 .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_AddsSpaceAfterAbbreviationDots()
        {
            const string input = "т.е. т.д.";
            const string expected = "т . е . т . д .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesExclamationWithDoubleExclamation()
        {
            const string input = "ПЧД";
            const string expected = "Привет , что делаешь ?";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesHaWithLaughter()
        {
            const string input = "Это смешно, ха";
            const string expected = "Это смешно , хахахахахахахахахаха";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesVhWithLaughter()
        {
            const string input = "Это смешно , вх";
            const string expected = "Это смешно , вхвхвхвхвхвхвхвхвхвх";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }
    }
}