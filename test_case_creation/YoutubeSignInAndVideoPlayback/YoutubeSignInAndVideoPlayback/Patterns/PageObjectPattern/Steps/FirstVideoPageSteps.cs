﻿namespace YoutubeSignInAndVideoPlayback.pages.PageObjectPattern.steps
{
    class FirstVideoPageSteps : BasePageSteps
    {
        private FirstVideoPage firstVideoPage = new FirstVideoPage();

        public void SignOutFromYouTube()
        {
            firstVideoPage.ClickAvatarButton();
            firstVideoPage.ClickSignOutButton();
        }
    }
}
