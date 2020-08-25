using System;
using Xunit;
using KeyboardPaste;


namespace Testing
{
    public class UnitTest1
    {
        private readonly Pastex testpaste;

        public UnitTest1()
        {
            testpaste = new Pastex();
        }
        [Fact]
        public void getFromKeyboard()
        {
            var hasil = testpaste.clipboardIsNotNull();
            Assert.True(hasil, "Clipboard Kosong");
        }
    }
}
