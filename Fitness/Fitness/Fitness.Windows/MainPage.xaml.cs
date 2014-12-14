using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Fitness
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Logika logika = new Logika();
        List<Pytanie> Pytania = new List<Pytanie>()
        {
            new Pytanie(){Tresc = "1. Jak często spożywa Pan/Pani alkohol?", pytania = new string[]{"często", "rzadko", "czasami", "wcale"}, Waga = new int[]{1,2,3,4}, Kategoria = 1},
            new Pytanie(){Tresc = "2. Czy w kuchni używa Pan/Pani dużo soli?", pytania = new string[]{"często", "czasami", "rzadko", "wcale"}, Waga = new int[]{1,2,3,4}, Kategoria = 1},
            new Pytanie(){Tresc = "3. Czy spożywa Pan/Pani ciemne pieczywo?", pytania = new string[]{"tak, zawsze", "tak, często", "tak, rzadko", "nie, wcale"}, Waga = new int[]{1,2,3,4}, Kategoria = 1},
            new Pytanie(){Tresc = "1. Jak długo spędza Pan/Pani czas przy komputerze?", pytania = new string[]{"wcale", "czasami", "długo", "bardzo długo"}, Waga = new int[]{1,2,3,4}, Kategoria = 2},
            new Pytanie(){Tresc = "2. Ile razy w miesiącu ćwiczy Pan/Pani na siłowni?", pytania = new string[]{"7-10", "4-6", "1-3", "0"}, Waga = new int[]{1,2,3,4}, Kategoria = 2},
            new Pytanie(){Tresc = "3. Czy uprawia Pan/Pani sport na świeżym powietrzu?", pytania = new string[]{"tak, często", "tak, czasami", "tak, rzadko", "nie, wcale"}, Waga = new int[]{1,2,3,4}, Kategoria = 2},
            new Pytanie(){Tresc = "1. Czy rozwiązuje Pan/Pani zagadki logiczne, rozwiązuje krzyżówki itp?", pytania = new string[]{"tak, często", "tak, czasami", "tak, rzadko", "nie, wcale"}, Waga = new int[]{1,2,3,4}, Kategoria = 3},
            new Pytanie(){Tresc = "2. Czy czyta Pan/Pani dużo książek?", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 3},
            new Pytanie(){Tresc = "3. Czy pracuje Pan/Pani umysłowo?", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 3},
            new Pytanie(){Tresc = "1. Czy ma Pan/Pani problem z nadciśnieniem?", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 4},
            new Pytanie(){Tresc = "2. Czy miewa Pan/Pani często depresję?", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 4},
            new Pytanie(){Tresc = "3. Czy często się Pan/Pani denerwuje?", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 4},
            new Pytanie(){Tresc = "1. Czy często się Pan/Pani śmieje?", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 5},
            new Pytanie(){Tresc = "2. Czy ma Pan/Pani wady postawy?", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 5},
            new Pytanie(){Tresc = "3. Czy jest Pan/Pani optymistą/ką", pytania = new string[]{"zdecydowanie tak", "raczej tak", "raczej nie", "zdecydowanie nie"}, Waga = new int[]{1,2,3,4}, Kategoria = 5},
        };

        List<string> odpowiedzi = new List<string>()
        {
            "odpowiedz 1", "odpowiedz 1", "odpowiedz 1",
            "odpowiedz 1", "odpowiedz 1", "odpowiedz 1", 
            "odpowiedz 1", "odpowiedz 1", "odpowiedz 1",
            "odpowiedz 1", "odpowiedz 1", "odpowiedz 1",
            "odpowiedz 1", "odpowiedz 1", "odpowiedz 1"
        };
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Clicked_ODP1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void Clicked_ODP2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void Clicked_ODP3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void Clicked_ODP4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }
    }
}
