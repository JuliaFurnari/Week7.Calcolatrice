using System;
using Xunit;
using Week7.Calcolatrice.Core;

namespace Week7.Calcolatrice.Test
{
    public class CalcolatriceTest
    {
        [Fact]
        public void TestSomma()
        {
            //Arrange: predisposizione del test
            CalcolatriceClass calcolatrice = new CalcolatriceClass();

            //ACT: chiata alla funzionalità da testare
            double risultato = calcolatrice.RisolviSomma(1, 1);

            //Assert: verifica del risultato           
            Assert.Equal(2, risultato);
        }

        [Fact]
        public void TestSottrazione()
        {
            
            CalcolatriceClass calcolatrice = new CalcolatriceClass();
            double risultato = calcolatrice.RisolviSottrazione(1, 1);          
            Assert.Equal(0, risultato);
        }

        [Fact]
        public void TestMoltiplicazione()
        {
            CalcolatriceClass calcolatrice = new CalcolatriceClass();
            double risultato = calcolatrice.RisolviMoltiplicazione(1, 1);         
            Assert.Equal(1, risultato);
        }

        [Fact]
        public void TestDivisione1()
        {
            CalcolatriceClass calcolatrice = new CalcolatriceClass();
            double? risultato = calcolatrice.RisolviDivisione(1, 1);          
            Assert.Equal(1, risultato);
        }

        [Fact]
        public void TestDivisione2()
        {
            CalcolatriceClass calcolatrice = new CalcolatriceClass();
            double? risultato = calcolatrice.RisolviDivisione(1, 0);         
            Assert.Null(risultato);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            CalcolatriceClass calcolatrice = new CalcolatriceClass(); 
            //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            CalcolatriceClass calcolatrice = new CalcolatriceClass(); 
            //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3.2, 3.2);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }
    }
}
