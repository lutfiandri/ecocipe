using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecocipe.Forms
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private string _category;
        private string _details;
        private Image _picture;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; lblCategory.Text = value; }
        }
        [Category("Custom Props")]
        public string Details
        {
            get { return _details; }   
            set { _details = value; lblDetails.Text = value; }
        }
        [Category("Custom Props")]
        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; pbPicture.Image = value; }
        }

        #endregion
    }
}
