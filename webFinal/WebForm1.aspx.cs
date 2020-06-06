using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webFinal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        object toplam, yaziToplam, turaToplam, ytSonuc;
        private static int yazi, tura, top;

        protected void Page_Load(object sender, EventArgs e)
        {
            toplam = Session["toplamSonuc"];
            yaziToplam = Session["yaziSonuc"];
            turaToplam = Session["turaSonuc"];
            ytSonuc = Session["ytSonuc"];
            if (toplam == null || yaziToplam == null || turaToplam == null || ytSonuc == null) lbl_deger.Visible = false;
            else
            {
                lbl_deger.Visible = true;
                lbl_YT.Text = ytSonuc.ToString();
                lbl_deger.Text = "Yazı: " + yaziToplam + " Tura: " + turaToplam + " Toplam: " + toplam;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            yazi = Convert.ToInt32(yaziToplam);
            tura = Convert.ToInt32(turaToplam);
            top = Convert.ToInt32(toplam);
            Random rnd = new Random();
            int rastgele = rnd.Next(0, 2);

            if (rastgele == 0)
            {
                yazi++;
                top++;
                lbl_YT.Text = "YAZI";
            }
            else
            {
                tura++;
                top++;
                lbl_YT.Text = "TURA";
            }

            lbl_yazi.Text = yazi.ToString();
            lbl_tura.Text = tura.ToString();
            lbl_top.Text = top.ToString();


            Session.Add("toplamSonuc", lbl_top.Text);
            Session.Add("yaziSonuc", lbl_yazi.Text);
            Session.Add("turaSonuc", lbl_tura.Text);
            Session.Add("ytSonuc", lbl_YT.Text);

            Response.Redirect("/WebForm1.aspx");

        }
    }
}