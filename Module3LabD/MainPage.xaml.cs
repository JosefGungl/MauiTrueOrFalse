namespace Module3LabD
{
    public partial class MainPage : ContentPage
    {
        int points = 0;
        int question = 0;
        string img1 = "badguy.svg";
        string img2 = "cave.svg";
        string img3 = "butler.svg";
        string img4 = "fighting.svg";
        public MainPage()
        {
            InitializeComponent();
            NextQ(question);
        }

        private void OnClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (question)
            {
                case 0:
                    //do you like crime?
                    if(button.ClassId == "false") {points++;}
                    question++;
                    NextQ(question);
                    break;
                case 1:
                    //do you like caves?
                    if (button.ClassId == "true") { points++; }
                    question++;
                    NextQ(question);
                    break;
                case 2:
                    //do you have a butler?
                    if (button.ClassId == "true") { points++; }
                    question++;
                    NextQ(question);
                    break;
                case 3:
                    //do you fight bad guys
                    if (button.ClassId == "true") { points++; }
                    question++;
                    NextQ(question);
                    break;
                    
            }
        }
        private void OnRestartClicked(object sender, EventArgs e)
        {
            question = 0;
            points = 0;
            NextQ(question);
        }
        private void NextQ(int q)
        {
           switch (question)
            {
                case 0:
                    //do you like crime?
                    TheImage.Source = img1;
                    TheText.Text = "Do you like crime?";
                    TBtn.IsVisible = true;
                    FBtn.IsVisible = true;
                    RBtn.IsVisible = false;
                    break;
                case 1:
                    //do you like caves?
                    TheImage.Source = img2;
                    TheText.Text = "Do you like caves?";
                    break;
                case 2:
                    //do you have a butler?
                    TheImage.Source = img3;
                    TheText.Text = "Do you have a butler?";
                    break;
                case 3:
                    //do you fight bad guys?
                    TheImage.Source = img4;
                    TheText.Text = "Do you fight bad guys?";
                    break;
                case 4:
                    //results
                    if (points == 4) 
                    { 
                        TheImage.Source = "batman.svg";
                        TheText.Text = "You are The Batman";
                        TBtn.IsVisible = false;
                        FBtn.IsVisible = false;
                        RBtn.IsVisible = true;
                    }
                    else
                    {
                        TheImage.Source = "averageman.svg";
                        TheText.Text = "You are an average person";
                        TBtn.IsVisible = false;
                        FBtn.IsVisible = false;
                        RBtn.IsVisible = true;
                    }
                    break;
            }
        }
    }
}