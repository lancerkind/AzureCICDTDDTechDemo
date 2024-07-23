﻿using PigLatinBlazor.TranslatorLogic;

namespace PigLatinBlazor.TranslatorLogic
{
    public class TranslatorTest
    {
        [Fact]
        public void TranslateWord()
        {
            PigLatinBlazor.TranslatorLogic.Translator translator = new();
            Assert.Equal("catay", translator.Translate("cat"));
        }

        [Fact]
        public void TranslateWord2()
        {
            Assert.Fail("Test fails in TranslateWord2");
        }
    }
}
