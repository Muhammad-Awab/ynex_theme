public class JobslandingmenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems (
            path: "landing-jobs/#home",
            type: "link",
            title: "Home",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing-jobs/#jobs",
            type: "link",
            title: "Jobs",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing-jobs/#candidates",
            type: "link",
            title: "Candidates",
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
                    path: "",
                    type: "empty",
                    title: "Level-1",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "-mission",
                    type: "empty",
                    title: "Level-1-1",
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
            path: "landing-jobs/#employers",
            type: "link",
            title: "For Employers",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "landing-jobs/#career-advice",
            type: "link",
            title: "Career Advice",
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
