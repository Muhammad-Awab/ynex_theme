public class LandingMenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems (
            path: "landing/#home",
            type: "link",
            title: "Home",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#about",
            type: "link",
            title: "About",
            selected: false,
            active: false,
            dirChange: false
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "More",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "landing/#statistics",
                    type: "link",
                    title: "Statistics",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "landing/#our-mission",
                    type: "link",
                    title: "Our Mission",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "landing/#features",
                    type: "link",
                    title: "Features",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "landing/#testimonials",
                    type: "link",
                    title: "Testimonials",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Level-2",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "empty",
                            title: "Level-2-1",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            type: "sub",
                            title: "Level-2-2",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Level-2-2-1",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Level-2-2-2",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                )
                            }
                        )
                    }
                )
            }
        ),
        
        new MainMenuItems (
            path: "landing/#testimonials",
            type: "link",
            title: "Clients",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#team",
            type: "link",
            title: "Team",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#pricing",
            type: "link",
            title: "Pricing",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#faq",
            type: "link",
            title: "Faq's",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing/#contact",
            type: "link",
            title: "Contact",
            selected: false,
            active: false,
            dirChange: false
        ),
    };

    public List<MainMenuItems> GetMenuData()
   {
        return MenuData;
    }
}
