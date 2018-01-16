using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace ClickingGame//By: Dejin1
{   
    public partial class Form1 : Form
        {
        SoundPlayer sndplayr = new SoundPlayer(Properties.Resources.Theme);//Theme song

        static Timer coinTimer = new Timer();//allows 1 second to pass before increasing coins when implimented.
            public int Shoot = 0;           //Shoot Counter
            public int coin = 200;          //Coins start Amount
            public int Reload = 0;          //Reload Counter
            public int goo = 0;             //Goomba Amount
            public int shroom = 0;          //Mushrooms Amount
            public int red = 0;             //Red Coins Amount
            public int stars = 0;           //Stars Amount          
            public int Cap = 5;             //Fireball Limit
            public int Xp = 0;              //Coincides with the integer Lvl and Xp
            bool shop = false;              //Used to see if user clicked Shop
            bool Ugrades = false;           //Used to see if user clicked Upgrades
            bool MusicPlaying = false;      //Bool to Help determine if music is playing
            public int Ammo = 1;            //Used for ammo upgrades
            public int FireSpeed = 0;       //Used for FireSpeed upgrades
            public int ReloadSpeed = 1;     //Used for ReloadSpeed upgrades
            public int CoinUp = 1;          //Used For Fireball Coin Increase
            
        public Form1()
            {
                InitializeComponent();      //Default Start                          
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;                                             ////Have no idea why or how this works to disable flickering
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            /////////////////////////////////////////////////////////////////////////////////////////////////////                                                                               
                button1.Visible = false;    //Goomba Button      Hides until ShopBtn Clicked
                button2.Visible = false;    //Stars Button       Hides until ShopBtn Clicked
                button3.Visible = false;    //Red Coins Button   Hides until ShopBtn Clicked
                button4.Visible = false;    //Shrooms Button     Hides until ShopBtn Clicked      
                button5.Visible = false;    //Fireball Ammo      Hides until ShopBtn Clicked
                t10.Visible = false;        //Star txt           Hides until ShopBtn Clicked  
                g10.Visible = false;        //Goomba txt         Hides until ShopBtn Clicked
                s10.Visible = false;        //Shrooms txt        Hides until ShopBtn Clicked
                r10.Visible = false;        //Red Coins txt      Hides until ShopBtn Clicked
                fa10.Visible = false;       //FirAmmo txt        Hides until ShopBtn Clicked
                detail10.Visible = false;   //Details            Hides until ShopBtn Clicked
                fp10.Visible = false;       //Firepwrtxt         Hides until Upgrades Btn Clicked
                FPBtn.Visible = false;      //FirePowerBtn       Hides until Upgrades Btn Clicked
                label9.Visible = false;     //Upgrades           Hides until Upgrades Btn Clicked
                label10.Visible = false;    //Upgrades           Hides until Upgrades Btn Clicked
                label11.Visible = false;    //Upgrades           Hides until Upgrades Btn Clicked
                label12.Visible = false;    //Upgrades           Hides until Upgrades Btn Clicked
                label21.Visible = false;    //Upgrades           Hides until Upgrades Btn Clicked
                label22.Visible = false;    //Upgrades           Hides until Upgrades Btn Clicked
                label23.Visible = false;    //Upgrades           Hides until Upgrades Btn Clicked
                label24.Visible = false;    //Upgrades           Hides until Upgrades Btn Clicked

        }

            public void Timer(Object myObject, EventArgs myEventArgs)//What I Want done When timer goes off
            {
                coin++;//Add Monay
                label7.Text = Convert.ToString(coin);//Update Monay
                coinTimer.Enabled = true;//timer on
            }
    
            private void ShootBtn_Click(object sender, EventArgs e)//Fireball
            {
            
            if (ShootTimer.Enabled == false)//Are you already Shooting?
                {
                    if (ReloadTimer.Enabled == false)//Are you already reloading?
                {
                    
                    if (Cap > 0)//U got bullets?
                        {
                        ShootTimer.Start();//start timer for progress bar
                        coin+= + (CoinUp*5); //add coin + coin Upgrade
                            Cap--;  //decrease ammo amount
                            Shoot++;//add shot 
                            Xp++;   //add Xp
                        #region FireSound
                        ////////////////////////////////////////////////////////////////////////
                        try
                        {
                            SoundPlayer sndplayr = new
                                     SoundPlayer(ClickingGame.Properties.Resources.FBsound);
                            sndplayr.Play();
                        }                                                                       //Plays fireball sound
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),
                                           "Error");
                        }
                        ///////////////////////////////////////////////////////////////////////
                        #endregion
                    }

                    label5.Text = Convert.ToString(Shoot);//Adds Exp per shot
                        lbl20.Text = Convert.ToString(Shoot); //Adds Shots
                        label3.Text = Convert.ToString(Cap);  //Shows Capacity each time user clicks shoot
                        label7.Text = Convert.ToString(coin); //Shows coins amount each time user clicks shoot
                    }
                }
            }

            private void ReloadBtn_Click(object sender, EventArgs e)
            {
                if (ReloadTimer.Enabled == false)
                {
                    if (ShootTimer.Enabled == false)
                    {
                        ReloadTimer.Start();
                        Reload++;//counts reloads
                        Cap *= 0;//gets rid of excess ammo to simulate a maximum clip
                        Cap += Ammo * 5; //Finds if ammo upgrades have been purchased then sets it
                    #region Reload Sound
                    ////////////////////////////////////////////////////////////////////////
                    try
                    {
                        SoundPlayer sndplayr = new
                        SoundPlayer(ClickingGame.Properties.Resources.Mush_Appear);
                        sndplayr.Play();
                    }                                                                       //Plays Reload sound
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),
                                       "Error");
                    }
                    ///////////////////////////////////////////////////////////////////////
                    #endregion
                    //everything below refresh's the label txt to reflect its current value.
                        ReloadNum.Text = Convert.ToString(Reload);
                        label3.Text = Convert.ToString(Cap);
                        label5.Text = Convert.ToString(Shoot);
                        label7.Text = Convert.ToString(coin);
                        //end   
                    }
                }
            }

            private void Form1_Load(object sender, EventArgs e)//Only goes off once when form loads
            {
                label7.Text = Convert.ToString(coin);//Updates coin amount once loaded.
            }

            private void ShopBtn_Click(object sender, EventArgs e)
            {
                if (shop == true)//when ShopBtn Clicked hide all this crap
                {       
                shop = false;
                    button1.Visible = false;
                    button4.Visible = false;
                    button3.Visible = false;
                    button2.Visible = false;
                    button5.Visible = false;
                    fa10.Visible = false;
                    g10.Visible = false;
                    s10.Visible = false;
                    r10.Visible = false;
                    t10.Visible = false;
                    detail10.Visible = false;
                    fp10.Visible = false;
                    FPBtn.Visible = false;
            }

                else
                {
                    //when ShopBtn Clicked Show all this crap
                    shop = true;
                #region coinsound
                ////////////////////////////////////////////////////////////////////////
                try
                {
                    SoundPlayer sndplayr = new
                             SoundPlayer(ClickingGame.Properties.Resources.Coin_sound);
                    sndplayr.Play();
                }                                                                       //Plays Coin sound
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),
                                   "Error");
                }
                ///////////////////////////////////////////////////////////////////////
                #endregion
                button1.Visible = true;
                    button4.Visible = true;
                    button3.Visible = true;
                    button2.Visible = true;
                    button5.Visible = true;
                    fa10.Visible = true;
                    g10.Visible = true;
                    s10.Visible = true;
                    r10.Visible = true;
                    t10.Visible = true;
                    detail10.Visible = true;
                    fp10.Visible = true;
                    FPBtn.Visible = true;
                 }
            }

            private void button1_Click(object sender, EventArgs e)//Gets goomba for 1 star
            {
                if (stars >= 1)
                {
                    stars -= 1;
                    goo++;//goomba
                    label20.Text = Convert.ToString(goo);
                    label15.Text = Convert.ToString(stars);//Update Star amount

                    coinTimer.Tick += new EventHandler(Timer);//Creates a Timed Increase of coins
                    coinTimer.Interval = 1000;//1 per sec
                    coinTimer.Start();               
                }
            }

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)//Cleanup
            {
            #region Game Over Sound
            ////////////////////////////////////////////////////////////////////////////////
            try
            {
                SoundPlayer sndplayr = new
                         SoundPlayer(ClickingGame.Properties.Resources.Gameover);
                sndplayr.Play();
            }                                                                       //Plays Game Over
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),
                               "Error");
            }
            System.Threading.Thread.Sleep(3000);//finish song
                                                /////////////////////////////////////////////////////////////////////////////////
            #endregion
            Dispose();
                Environment.Exit(0);//if not added program continues to run cuz of timer.
            }

            private void button5_Click(object sender, EventArgs e)//Fireball Ammo Btn
            {
                if (coin >= 50)
                {
                    coin -= 50;//Take money
                    Ammo++;//Add ammo
                    label10.Text = "+" + Convert.ToString((Ammo - 1) * 5);//Update Ammo Upgrade
                    label7.Text = Convert.ToString(coin);//Update coin amount
                }
            }

        private void button4_Click(object sender, EventArgs e)//Mush/Reloadspeed Upgrade
        {
            if (coin >= 500 && ReloadSpeed < 16)//keeps reload speed under 15
            {
                coin -= 500;//Take coins
             
                ++ReloadSpeed;//faster reload
                ++shroom;//how many shrooms you got

                label7.Text = Convert.ToString(coin);//Update coin amount
                
                label13.Text = Convert.ToString(shroom);

                if (ReloadSpeed == 16)//Used to Replace "Speed" with "Maxed" if Value cant be increased
                {
                    label22.Text = Convert.ToString("+" + (ReloadSpeed - 1) + " Reload Maxed");//Update reload upgrade amount
                }
                else
                {
                    label22.Text = Convert.ToString("+" + (ReloadSpeed - 1) + " Reload Speed");//Update reload upgrade amount
                }
            }
           
        }

        private void ReloadTimer_Tick(object sender, EventArgs e)//For Progress bar to be used as a Reloading Visual
        { 
            Reload1.Maximum = 100;
            Reload1.Step = 1*(ReloadSpeed);
            Reload1.PerformStep();

            if (bar4.Value == 100 || Reload1.Value == 100)
            {
                ReloadTimer.Enabled = false;
                Reload1.Value = 0;
                bar4.Value = 0;      
            }
            bar4.Value = Reload1.Value;
        }

        private void ShootTimer_Tick(object sender, EventArgs e)//For Progress bar to be used as a Shooting Visual
        {
            Fire1.Maximum = 100;
            Fire1.Step = 2*(FireSpeed+1);
            Fire1.PerformStep();
            if (Fire1.Value == 100)
            {
                Fire1.Value = 0;
                ShootTimer.Enabled = false;
            }
            bar3.Value = Fire1.Value;
        }

        private void button2_Click(object sender, EventArgs e)//Buy Star
        {
            if (coin >= 1000)
            {
                coin -= 1000;//Take coins
                ++stars;//Adds a Star (currency)
                label7.Text = Convert.ToString(coin);//Update coin amount
                label15.Text = Convert.ToString(stars);//Update Star amount
            }
        }

        private void FPBtn_Click(object sender, EventArgs e)
        {
            if (coin >= 100)
            {
                coin -= 100;//Take coins
                CoinUp++;//Adds Firepower(morecoins)
                label7.Text = Convert.ToString(coin);//Update coin amount
                label24.Text = Convert.ToString("+" + CoinUp*5 + " coins");//Update power up
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Ugrades == true)//when UBtn Clicked hide all this crap
            {
                Ugrades = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
            }

            else
            {
                //when UBtn Clicked Show all this crap
                Ugrades = true;
                #region pipesound
                ////////////////////////////////////////////////////////////////////////
                try
                {
                    SoundPlayer sndplayr = new
                             SoundPlayer(ClickingGame.Properties.Resources.pipe);
                    sndplayr.Play();
                }                                                                       //Plays pipe sound
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),
                                   "Error");
                }
                ///////////////////////////////////////////////////////////////////////
                #endregion
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
            }     
        }

        private void button3_Click(object sender, EventArgs e)//Shoot Speed Upgrade
        {
            if (stars >= 3 && FireSpeed<7)
            {
                stars -= 3;//Take stars
                red++;//Adds redcoins
                FireSpeed++;
                label14.Text = Convert.ToString(red);//Update redcoins amount
                label15.Text = Convert.ToString(stars);//Update Star amount
                if (FireSpeed == 7)
                {
                    label21.Text = Convert.ToString("+" + red + " FireSpeed Maxed");//Update power up
                }
                else
                {
                    label21.Text = Convert.ToString("+" + red + " FireSpeed");//Update power up
                }
            }
        }

        public void button7_Click(object sender, EventArgs e)//Theme Song
        {
            #region Theme
            ////////////////////////////////////////////////////////////////////////
            if (MusicPlaying == false)
            {
                try
                {                  
                    sndplayr.Play();
                }                                                                       //Plays Theme Song
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),"Error");
                }
                ThemeSong.Enabled = true;
                MusicPlaying = true;
            }
           
            else
            {
                sndplayr.Stop();
                MusicPlaying = false;
            }
            ///////////////////////////////////////////////////////////////////////
            #endregion
        }

        private void ThemeSong_Tick(object sender, EventArgs e)
        {
            ThemeSong.Enabled = false;
            MusicPlaying = false;
            sndplayr.Stop();
        }


    }//class form1      
 }//Namespace
