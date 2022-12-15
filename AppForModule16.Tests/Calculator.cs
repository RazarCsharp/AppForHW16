using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForModule16.Tests
{
    public class Calculator
    {
        /// <summary>
        /// сложение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Тестируем сложение
        /// </summary>
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(30, 10) == 40);
        }

        /// <summary>
        /// вычетание
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Тесстируем вычитание
        /// </summary>
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(30, 10) == 20);
        }

        /// <summary>
        /// умножение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Тестируем умножение
        /// </summary>
        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(30, 10) == 300);
        }


        /// <summary>
        /// деление
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
        /// <summary>
        /// Тестируем деление
        /// </summary>
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(25, 5) == 5);
        }
        /// <summary>
        /// Тестируем деление на ноль
        /// </summary>
        [Test]
        public void DivisionByZero()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(1, 0));
        }
    }
}
