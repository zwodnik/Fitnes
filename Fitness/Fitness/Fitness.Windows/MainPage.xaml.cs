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

        List<Pytanie> Pytania = new List<Pytanie>()
        {
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 1},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 1},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 1},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 2},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 2},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 2},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 3},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 3},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 3},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 4},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 4},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 4},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 5},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 5},
            new Pytanie(){Tresc = "Pytanie 1", pytania = new string[]{"Odpowiedz1", "Odpowiedz2", "Odpowiedz3", "Odpowiedz4"}, Waga = new int[]{1,2,3,4}, Kategoria = 5},
        };
        public MainPage()
        {
            this.InitializeComponent();
        }
    }
}
