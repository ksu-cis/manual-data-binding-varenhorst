using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create the note to add to our editor.
        private Note note = new Note();
        public MainWindow()
        {
            InitializeComponent(); //takes the XAML and applies it to class.
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler to create a new note and apply it to the editor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
            //Editor.OnNoteChange(note.Title, note.Body); //alternative | Fragile.
        }

        /// <summary>
        /// Event Handler to clear the note. Replaces it with an empty string.
        /// </summary>
        /// <param name="snder"></param>
        /// <param name="e"></param>
        public void OnClearNote(object snder, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Event Handler to mutate the current note.
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">event</param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Master Splinter";
            note.Body = "There is no monster more dangerous than the lack of compassion. Or is there?";

        }
    }
}
