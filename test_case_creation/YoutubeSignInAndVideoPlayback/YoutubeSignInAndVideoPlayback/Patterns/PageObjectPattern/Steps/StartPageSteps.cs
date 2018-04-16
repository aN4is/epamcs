﻿namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    class StartPageSteps : BasePageSteps
    {
        private StartPage startPage = new StartPage();

        public void OpenSignInPage()
        {            
            startPage.ClickSignInButton();           
        }

        public void OpenYoutubeUrl()
        {
            startPage.OpenUrl();
        }

    }
}
