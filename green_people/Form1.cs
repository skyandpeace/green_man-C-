using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace green_people
{
    public partial class frmsmallgreenman : Form
    {
        public frmsmallgreenman()
        {
            InitializeComponent();
        }
        int p = 1;
        int passtime;
        int x = 0, y = 0;

        

        private void frmsmallgreenman_Load(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(480, 510);
            for (int i = 0; i < 256; i++)
            {
                RadioButton btnclose = new RadioButton();
                btnclose.Size = new Size(30, 30);
                groupBox1.Controls.Add(btnclose);
                x += 30;
                if (i % 16 == 0)
                {
                    y += 30;
                    x = 0;
                }
                btnclose.Location = new Point(x, y);
            }
            for (int i = 0; i < 256; i++)
                groupBox1.Controls[i].BackColor = Color.White;
            greenman(1);
            btnstop.Enabled = false;
        }


        private void btnstart_Click(object sender, EventArgs e)
        {
            passtime = 0;
            tmrsmallgreenman.Enabled = true;
            tmrsmallgreenman.Interval = 50;
            btnstart.Enabled = false;
            btnstop.Enabled = true;
        }

        private void tmrsmallgreenman_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
                groupBox1.Controls[i].BackColor = Color.White;
                p++;
            if (p >= 8)
                p = 1;
            passtime += tmrsmallgreenman.Interval;
            if (passtime == 60000)
            {
                greenman(1);
                btnstop.PerformClick();
                return;
            }
            else if (passtime >= 50000)
                tmrsmallgreenman.Interval = 10;
            else if (passtime >= 30000)
                tmrsmallgreenman.Interval = 1;
            greenman(p);
         }

        private void btnstop_Click(object sender, EventArgs e)
        {
            tmrsmallgreenman.Enabled = false;
            btnstop.Enabled = false;
            btnstart.Enabled = true;
        }
        void greenman(int pick)
        {
            switch (pick)
            {

                //1
                case 1:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 20:
                            case 21:
                            case 35:
                            case 36:
                            case 37:
                            case 38:
                            case 52:
                            case 53:
                            case 69:
                            case 70:
                            case 85:
                            case 86:
                            case 87:
                            case 88:
                            case 89:
                            case 101:
                            case 102:
                            case 103:
                            case 106:
                            case 117:
                            case 118:
                            case 119:
                            case 123:
                            case 132:
                            case 135:
                            case 136:
                            case 151:
                            case 152:
                            case 167:
                            case 169:
                            case 182:
                            case 186:
                            case 187:
                            case 198:
                            case 203:
                            case 214:
                            case 219:
                            case 227:
                            case 228:
                            case 229:
                            case 234:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
                //2
                case 2:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 20:
                            case 21:
                            case 35:
                            case 36:
                            case 37:
                            case 38:
                            case 52:
                            case 53:
                            case 69:
                            case 70:
                            case 85:
                            case 86:
                            case 87:
                            case 88:
                            case 101:
                            case 102:
                            case 105:
                            case 117:
                            case 118:
                            case 119:
                            case 122:
                            case 132:
                            case 135:
                            case 136:
                            case 138:
                            case 151:
                            case 152:
                            case 166:
                            case 169:
                            case 181:
                            case 185:
                            case 186:
                            case 187:
                            case 197:
                            case 203:
                            case 214:
                            case 217:
                            case 218:
                            case 228:
                            case 229:
                            case 230:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
                //3
                case 3:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 20:
                            case 21:
                            case 35:
                            case 36:
                            case 37:
                            case 38:
                            case 52:
                            case 53:
                            case 69:
                            case 70:
                            case 85:
                            case 86:
                            case 87:
                            case 101:
                            case 102:
                            case 104:
                            case 118:
                            case 119:
                            case 121:
                            case 134:
                            case 135:
                            case 137:
                            case 151:
                            case 152:
                            case 166:
                            case 167:
                            case 168:
                            case 181:
                            case 184:
                            case 197:
                            case 201:
                            case 202:
                            case 213:
                            case 214:
                            case 219:
                            case 230:
                            case 233:
                            case 234:
                            case 245:
                            case 246:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
                //4
                case 4:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 21:
                            case 22:
                            case 36:
                            case 37:
                            case 38:
                            case 39:
                            case 53:
                            case 54:
                            case 70:
                            case 71:
                            case 86:
                            case 87:
                            case 88:
                            case 102:
                            case 103:
                            case 105:
                            case 119:
                            case 120:
                            case 134:
                            case 135:
                            case 136:
                            case 151:
                            case 152:
                            case 166:
                            case 167:
                            case 168:
                            case 181:
                            case 184:
                            case 197:
                            case 201:
                            case 214:
                            case 215:
                            case 218:
                            case 231:
                            case 234:
                            case 245:
                            case 246:
                            case 247:
                            case 249:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
                //5
                case 5:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 21:
                            case 22:
                            case 36:
                            case 37:
                            case 38:
                            case 39:
                            case 53:
                            case 54:
                            case 70:
                            case 71:
                            case 86:
                            case 87:
                            case 88:
                            case 102:
                            case 103:
                            case 104:
                            case 119:
                            case 120:
                            case 135:
                            case 136:
                            case 137:
                            case 151:
                            case 152:
                            case 166:
                            case 168:
                            case 169:
                            case 184:
                            case 185:
                            case 186:
                            case 200:
                            case 201:
                            case 202:
                            case 217:
                            case 218:
                            case 234:
                            case 249:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
                //6
                case 6:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 21:
                            case 22:
                            case 36:
                            case 37:
                            case 38:
                            case 39:
                            case 53:
                            case 54:
                            case 70:
                            case 71:
                            case 86:
                            case 87:
                            case 88:
                            case 102:
                            case 103:
                            case 104:
                            case 117:
                            case 119:
                            case 120:
                            case 121:
                            case 134:
                            case 135:
                            case 136:
                            case 137:
                            case 150:
                            case 151:
                            case 152:
                            case 166:
                            case 167:
                            case 168:
                            case 181:
                            case 183:
                            case 184:
                            case 198:
                            case 200:
                            case 201:
                            case 213:
                            case 214:
                            case 218:
                            case 234:
                            case 249:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
                //7
                case 7:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 21:
                            case 22:
                            case 36:
                            case 37:
                            case 38:
                            case 39:
                            case 53:
                            case 54:
                            case 70:
                            case 71:
                            case 86:
                            case 87:
                            case 88:
                            case 102:
                            case 103:
                            case 104:
                            case 105:
                            case 116:
                            case 117:
                            case 118:
                            case 119:
                            case 120:
                            case 121:
                            case 134:
                            case 135:
                            case 136:
                            case 150:
                            case 151:
                            case 152:
                            case 166:
                            case 167:
                            case 168:
                            case 181:
                            case 183:
                            case 184:
                            case 197:
                            case 201:
                            case 202:
                            case 212:
                            case 213:
                            case 219:
                            case 235:
                            case 249:
                            case 250:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
                //8
                case 8:
                    for (int i = 0; i < 256; i++)
                        switch (i)
                        {
                            case 20:
                            case 21:
                            case 35:
                            case 36:
                            case 37:
                            case 38:
                            case 52:
                            case 53:
                            case 70:
                            case 86:
                            case 87:
                            case 88:
                            case 102:
                            case 103:
                            case 105:
                            case 116:
                            case 117:
                            case 118:
                            case 119:
                            case 122:
                            case 131:
                            case 135:
                            case 136:
                            case 138:
                            case 151:
                            case 152:
                            case 167:
                            case 169:
                            case 182:
                            case 186:
                            case 197:
                            case 203:
                            case 211:
                            case 212:
                            case 220:
                            case 236:
                            case 251:
                            case 252:
                                groupBox1.Controls[i].BackColor = Color.Green;
                                break;
                        }
                    break;
            }
        }

    }
}
