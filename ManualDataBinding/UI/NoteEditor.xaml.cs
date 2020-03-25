using System;
using System.Collections.Generic;
using System.Text;
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

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {
        private Note note;

        /// <summary>
        /// The note that will be edited by this control.
        /// </summary>
        public Note Note 
        {
            get
            {
                return note;
            }
            set
            {
                if (note != null) note.NoteChangedEvent -= OnNoteChange;
                note = value;
                if (note != null)
                {
                    note.NoteChangedEvent += OnNoteChange; //future change
                    OnNoteChange(note, new EventArgs());
                } 
            }
        }
        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Message passing for note change.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="body"></param>
        public void OnNoteChange(object sender, EventArgs e)
        {
            if(Note == null) // if notee is null, end;
            {
                return;
            }

            Title.Text = Note.Title;
            Body.Text = Note.Body;
        }

        /// <summary>
        /// Event Handler for title change.
        /// </summary>
        /// <param name="snder"></param>
        /// <param name="e"></param>
        public void OnTitleChange(object snder, TextChangedEventArgs e)
        {
            Note.Title = Title.Text;
        }


        /// <summary>
        /// Event Handler for body change.
        /// </summary>
        /// <param name="snder"></param>
        /// <param name="e"></param>
        public void OnBodyChange(object snder, TextChangedEventArgs e)
        {
            Note.Body = Body.Text;
        }
    }
}

