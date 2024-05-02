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
            const string input = "������,���!��� ����.";
            const string expected = "������ , ��� ! ��� ���� .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesHyphensWithEmDash()
        {
            const string input = "��� ���� - � ��������.";
            const string expected = "��� ���� � � �������� .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_RemovesExtraSpaces()
        {
            const string input = "���   ������     �   �����   �������     �����������      ��������.";
            const string expected = "��� ������ � ����� ������� ����������� �������� .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesQuotesWithChevrons()
        {
            const string input = "\"��� ������ � ��������\".";
            const string expected = "���� ������ � ��������� .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesYearRangeWithEmDash()
        {
            const string input = "��� ��������� �  2022-2023.";
            const string expected = "��� ��������� � 2022�2023 .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesSpaceHyphenSpaceWithEmDash()
        {
            const string input = "��� �������� - �� 10 �� 20.";
            const string expected = "��� �������� � �� 10 �� 20 .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_AddsSpaceAfterAbbreviationDots()
        {
            const string input = "�.�. �.�.";
            const string expected = "� . � . � . � .";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesExclamationWithDoubleExclamation()
        {
            const string input = "���";
            const string expected = "������ , ��� ������� ?";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesHaWithLaughter()
        {
            const string input = "��� ������, ��";
            const string expected = "��� ������ , ��������������������";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProcessText_ReplacesVhWithLaughter()
        {
            const string input = "��� ������ , ��";
            const string expected = "��� ������ , ��������������������";

            string result = _form.ProcessText(input);

            Assert.Equal(expected, result);
        }
    }
}