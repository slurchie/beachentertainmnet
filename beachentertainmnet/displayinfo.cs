using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace beachentertainmnet
{
    class displayinfo : SplitContainer
    {
        PictureBox photo;
        RichTextBox textinfo;
        PictureBox logo;
        IShowInfo selectobject;


        TableLayoutPanel backgroundphoto;
        public displayinfo() : base()
        {
            Orientation = Orientation.Horizontal;
            textinfo = new RichTextBox();
            textinfo.Dock = DockStyle.Fill;
            textinfo.ReadOnly = true;
            Panel2.Controls.Add(textinfo);
            photo = new PictureBox();
            backgroundphoto = new TableLayoutPanel();

            backgroundphoto.Dock = DockStyle.Fill;
            backgroundphoto.ColumnCount = 3;
            backgroundphoto.RowCount = 1;
            backgroundphoto.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            backgroundphoto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            backgroundphoto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            backgroundphoto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            backgroundphoto.ColumnStyles[0].Width = 20;
            backgroundphoto.ColumnStyles[1].Width = 60;
            backgroundphoto.ColumnStyles[2].Width = 20;
            backgroundphoto.Visible = true;
            Panel1.Controls.Add(backgroundphoto);
            logo = new PictureBox();
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.Dock = DockStyle.Fill;
            backgroundphoto.Controls.Add(logo);
            backgroundphoto.Controls.Add(photo);
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
            photo.Dock = DockStyle.Fill;
            Panel2.BackColor = Color.AntiqueWhite;
        }
        public void showInfo(IShowInfo objectShow, DateTime date)
        {
            selectobject = objectShow;
            photo.Image = objectShow.showimage();
            textinfo.Text = objectShow.showText(date);
        }
        public void refresh(DateTime date)
        {
            if (selectobject != null)

                textinfo.Text = selectobject.showText(date);

        }
    }
    }
