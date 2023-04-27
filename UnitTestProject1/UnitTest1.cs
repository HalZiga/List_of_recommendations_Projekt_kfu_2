using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using Projekt_kfu_2;
using Label = System.Windows.Forms.Label;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Regestration form = new Regestration();
            TextBox textBox = form.Controls["textBoxEmail"] as TextBox;
            textBox.Text = "users@gmail.com";

            bool containsAtSymbol = textBox.Text.Contains("@");

            Assert.IsTrue(containsAtSymbol);
        }
        public void TestOpenAnotherForm()
        {
            Avtorisation form = new Avtorisation();
            Button button = form.Controls["buttonEntrance"] as Button;

            button.PerformClick();

            Assert.IsNotNull(System.Windows.Forms.Application.OpenForms["RegistrUser"]);
        }

        [TestMethod]
        public void TestOpenAnotherForm2()
        {
            Avtorisation form = new Avtorisation();
            Button button = form.Controls["buttonRegestration"] as Button;

            button.PerformClick();

            Assert.IsNotNull(System.Windows.Forms.Application.OpenForms["Regestration"]);
        }
        public void TestTextBoxContainsAsciiCharacters()
        {

            Regestration form = new Regestration();
            TextBox textBox = form.Controls["textBoxEmail"] as TextBox;
            textBox.Text = "Hello, world!";


            bool containsNonAsciiCharacters = textBox.Text.Any(c => c > 127);


            Assert.IsFalse(containsNonAsciiCharacters);
        }
        public void TestLabelIsDisplayedOnForm()
        {
            User form = new User();
            Label label = form.Controls["label1"] as Label;

            Assert.IsNotNull(label);
            Assert.IsTrue(form.Controls.Contains(label));
            Assert.IsTrue(label.Visible);
        }
    }
}
