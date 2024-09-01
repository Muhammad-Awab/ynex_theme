public class MenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems(
            menuTitle: "MAIN"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Dashboards",
            icon: "bx bx-home",
            badgeValue: "12",
            badgeClass: "bg-warning-transparent",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
              new MainMenuItems (
                    path: "/home",
                    type: "link",
                    title: "CRM",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index2",
                    type: "link",
                    title: "Ecommerce",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index3",
                    type: "link",
                    title: "Crypto",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index4",
                    type: "link",
                    title: "Jobs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index5",
                    type: "link",
                    title: "NFT",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index6",
                    type: "link",
                    title: "Sales",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index7",
                    type: "link",
                    title: "Analytics",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index8",
                    type: "link",
                    title: "Projects",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index9",
                    type: "link",
                    title: "HRM",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index10",
                    type: "link",
                    title: "Stocks",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
              new MainMenuItems (
                    path: "/index11",
                    type: "link",
                    title: "Courses",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
               new MainMenuItems (
                    path: "/index12",
                    type: "link",
                    title: "Personal",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems(
            menuTitle: "PAGES"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Pages",
            icon: "bx bx-file-blank",
            badgeValue: "New",
            badgeClass: "bg-secondary-transparent",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/about-us",
                    type: "link",
                    title: "About Us",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/counter",
                    type: "link",
                    title: "Counters",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Blog",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                    new MainMenuItems (
                        path: "/blog",
                        type: "link",
                        title: "Blog",
                        selected: false,
                        active: false,
                        dirChange: false
                    ),
                    new MainMenuItems (
                        path: "/blog-details",
                        type: "link",
                        title: "Blog Details",
                        selected: false,
                        active: false,
                        dirChange: false
                    ),
                    new MainMenuItems (
                        path: "/blog-create",
                        type: "link",
                        title: "Create Blog",
                        selected: false,
                        active: false,
                        dirChange: false
                    ),
                    }
                ),
                new MainMenuItems (
                    path: "/chat",
                    type: "link",
                    title: "Chat",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/contacts",
                    type: "link",
                    title: "Contacts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/contact-us",
                    type: "link",
                    title: "Contact Us",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                type: "sub",
                title: "Ecommerce",
                selected: false,
                active: false,
                dirChange: false,
                children: new MainMenuItems[]
                {
                  new MainMenuItems (
                    path: "/add-products",
                    type: "link",
                    title: "Add Products",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/cart",
                    type: "link",
                    title: "Cart",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/checkout",
                    type: "link",
                    title: "Checkout",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/edit-products",
                    type: "link",
                    title: "Edit Products",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/order-details",
                    type: "link",
                    title: "Order Details",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/orders",
                    type: "link",
                    title: "Orders",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/products",
                    type: "link",
                    title: "Products",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/product-details",
                    type: "link",
                    title: "Product Details",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/products-list",
                    type: "link",
                    title: "Products List",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                  new MainMenuItems (
                    path: "/wishlist",
                    type: "link",
                    title: "Wishlist",
                    selected: false,
                    active: false,
                    dirChange: false
                  ),
                }
            ),
                new MainMenuItems (
                    type: "sub",
                    title: "Email",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/mail",
                            type: "link",
                            title: "Mail App",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/mail-settings",
                            type: "link",
                            title: "Mail Settings",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/empty",
                    type: "link",
                    title: "Empty",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/faq's",
                    type: "link",
                    title: "FAQ's",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "File Manager",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/file-manager",
                            type: "link",
                            title: "File Manager",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Invoice",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/invoice-create",
                            type: "link",
                            title: "Create Invoice",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice-details",
                            type: "link",
                            title: "Invoice Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice-list",
                            type: "link",
                            title: "Invoice List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/landing",
                    type: "external",
                    title: "Landing",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/landing-jobs",
                    type: "external",
                    title: "Jobs Landing",
                    badgeValue: "New",
                    badgeClass: "bg-secondary-transparent",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/notifications",
                    type: "link",
                    title: "Notifications",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pricing",
                    type: "link",
                    title: "Pricing",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profile",
                    type: "link",
                    title: "Profile",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/reviews",
                    type: "link",
                    title: "Reviews",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/team",
                    type: "link",
                    title: "Team",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/terms_conditions",
                    type: "link",
                    title: "Terms&Conditions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/timeline",
                    type: "link",
                    title: "Timeline",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/to-do-list",
                    type: "link",
                    title: "To Do List",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Task",
            icon: "bx bx-task",
            badgeValue: "New",
            badgeClass: "bg-secondary-transparent",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems ( 
                    path: "/task-kanban-board",
                    type: "link",
                    title: "Kanban Board",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/task-list-view",
                    type: "link",
                    title: "List View",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/task-details",
                    type: "link",
                    title: "Task Details",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Authentication",
            icon: "bx bx-fingerprint",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems ( 
                    path: "/coming-soon",
                    type: "link",
                    title: "Coming Soon",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Create Password",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/create-password-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/create-password-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Lock Screen",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/lockscreen-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/lockscreen-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Reset Password",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/reset-password-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/reset-password-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Sign Up",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/sign-up-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/sign-up-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Sign In",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/sign-in-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/sign-in-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Two Step Verification",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/two-step-verification-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/two-step-verification-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    path: "/under-maintenance",
                    type: "link",
                    title: "Under Maintenance",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Error",
            icon: "bx bx-error",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/401-error",
                    type: "link",
                    title: "Error 401",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/404-error",
                    type: "link",
                    title: "Error 404",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/500-error",
                    type: "link",
                    title: "Error 500",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            menuTitle: "GENERAL"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Ui Elements",
            icon: "bx bx-box",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/alerts",
                    type: "link",
                    title: "Alerts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/badge",
                    type: "link",
                    title: "Badge",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breadcrumb",
                    type: "link",
                    title: "Breadcrumb",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttons",
                    type: "link",
                    title: "Buttons",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttongroup",
                    type: "link",
                    title: "Button Group",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/cards",
                    type: "link",
                    title: "Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/dropdowns",
                    type: "link",
                    title: "Dropdowns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/images_figures",
                    type: "link",
                    title: "Images & Figures",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/links_interactions",
                    type: "link",
                    title: "Links & Interactions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/listgroup",
                    type: "link",
                    title: "List Group",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navs_tabs",
                    type: "link",
                    title: "Navs & Tabs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/object-fit",
                    type: "link",
                    title: "Object Fit",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pagination",
                    type: "link",
                    title: "Pagination",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/popovers",
                    type: "link",
                    title: "Popovers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/progress",
                    type: "link",
                    title: "Progress",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/spinners",
                    type: "link",
                    title: "Spinners",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/toasts",
                    type: "link",
                    title: "Toasts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/tooltips",
                    type: "link",
                    title: "Tooltips",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/typography",
                    type: "link",
                    title: "Typography",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Utilities",
            icon: "bx bx-medal",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/avatars",
                    type: "link",
                    title: "Avatars",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/borders",
                    type: "link",
                    title: "Borders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breakpoints",
                    type: "link",
                    title: "Breakpoints",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/colors",
                    type: "link",
                    title: "Colors",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/columns",
                    type: "link",
                    title: "Columns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/flex",
                    type: "link",
                    title: "Flex",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/gutters",
                    type: "link",
                    title: "Gutters",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/helpers",
                    type: "link",
                    title: "Helpers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/position",
                    type: "link",
                    title: "Position",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/more",
                    type: "link",
                    title: "Additional Content",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Forms",
            icon: "bx bx-file",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Form Elements",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/form_inputs",
                            type: "link",
                            title: "Inputs",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_check_radios",
                            type: "link",
                            title: "Checks & Radios",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_input_group",
                            type: "link",
                            title: "Input Group",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_select",
                            type: "link",
                            title: "Form Select",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_range",
                            type: "link",
                            title: "Range Slider",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_input_masks",
                            type: "link",
                            title: "Input Masks",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_file_uploads",
                            type: "link",
                            title: "File Uploads",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_dateTime_pickers",
                            type: "link",
                            title: "Date,Time Picker",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form_color_pickers",
                            type: "link",
                            title: "Color Picker",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Form Wizards",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/form-wizard",
                            type: "link",
                            title: "Js",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/blazor-form-wizard",
                            type: "link",
                            title: "Blazor",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/floating_labels",
                    type: "link",
                    title: "Floating Labels",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form_layout",
                    type: "link",
                    title: "Form Layouts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Form Editor",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/quill_editor",
                            type: "link",
                            title: "Quill Editor",
                            selected: false,
                            active: false,
                            dirChange: false
                        )
                    }
                ),
                new MainMenuItems (
                    path: "/form_validation",
                    type: "link",
                    title: "Validations",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form_select2",
                    type: "link",
                    title: "Select2",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Advanced Ui",
            icon: "bx bx-party",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/accordions_collpase",
                    type: "link",
                    title: "Accordion & Collapse",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/carousel",
                    type: "link",
                    title: "Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/draggable-cards",
                    type: "link",
                    title: "Draggable Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/modals_closes",
                    type: "link",
                    title: "Modals & Closes",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navbar",
                    type: "link",
                    title: "Navbars",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/offcanvas",
                    type: "link",
                    title: "Offcanvas",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/placeholders",
                    type: "link",
                    title: "Placeholders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ratings",
                    type: "link",
                    title: "Ratings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/slickcarousel",
                    type: "link",
                    title: "Slick Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/treeview",
                    type: "link",
                    title: "Treeview",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            path: "/widgets",
            type: "link",
            title: "Widgets",
            icon: "bx bx-gift",
            badgeValue: "Hot",
            badgeClass: "bg-danger-transparent",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            menuTitle: "WEB APPS"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Apps",
            icon: "bx bx-grid-alt",
            badgeValue: "New",
            badgeClass: "bg-secondary-transparent",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Calendar",
                    badgeValue: "",
                    badgeClass: "",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/full-calendar",
                            type: "link",
                            title: "Full Calendar",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blazor-calendar",
                            type: "link",
                            title: "Blazor Calendar",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/gallery",
                    type: "link",
                    title: "Gallery",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/sweet_alerts",
                    type: "link",
                    title: "Sweet Alerts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Projects",
                    badgeValue: "New",
                    badgeClass: "bg-secondary-transparent",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/projects-list",
                            type: "link",
                            title: "Projects List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/projects-overview",
                            type: "link",
                            title: "Project Overview",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/projects-create",
                            type: "link",
                            title: "Create Project",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Jobs",
                    badgeValue: "New",
                    badgeClass: "bg-secondary-transparent",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/job-details",
                            type: "link",
                            title: "Job Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-company-search",
                            type: "link",
                            title: "Search Company",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-search",
                            type: "link",
                            title: "Search Jobs",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-post",
                            type: "link",
                            title: "Job Post",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/jobs-list",
                            type: "link",
                            title: "Jobs List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-candidate-search",
                            type: "link",
                            title: "Search Candidate",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-candidate-details",
                            type: "link",
                            title: "Candidate-details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "NFT",
                    badgeValue: "New",
                    badgeClass: "bg-secondary-transparent",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/nft-marketplace",
                            type: "link",
                            title: "Market Place",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-details",
                            type: "link",
                            title: "NFT Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-create",
                            type: "link",
                            title: "Create NFT",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-wallet-integration",
                            type: "link",
                            title: "Wallet Integration",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-live-auction",
                            type: "link",
                            title: "Live Auction",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "CRM",
                    badgeValue: "New",
                    badgeClass: "bg-secondary-transparent",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/crm-contacts",
                            type: "link",
                            title: "Contacts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-companies",
                            type: "link",
                            title: "Companies",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-deals",
                            type: "link",
                            title: "Deals",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-leads",
                            type: "link",
                            title: "Leads",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Crypto",
                    badgeValue: "New",
                    badgeClass: "bg-secondary-transparent",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/crypto-transactions",
                            type: "link",
                            title: "Transactions",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-currency-exchange",
                            type: "link",
                            title: "Currency Exchange",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-buy_sell",
                            type: "link",
                            title: "Buy & Sell",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-marketcap",
                            type: "link",
                            title: "Marketcap",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-wallet",
                            type: "link",
                            title: "Wallet",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Nested Menu",
            icon: "bx bx-layer",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "empty",
                    title: "Nested-1",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Nested-2",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "empty",
                            title: "Nested-2-1",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            type: "sub",
                            title: "Nested-2-2",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-1",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-2",
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
            menuTitle: "TABLES & CHARTS"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Tables",
            icon: "bx bx-table",
            badgeValue: "3",
            badgeClass: "bg-success-transparent",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/tables",
                    type: "link",
                    title: "Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/grid-tables",
                    type: "link",
                    title: "Grid Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/data-tables",
                    type: "link",
                    title: "Data Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            type: "sub",
            title: "Charts",
            icon: "bx bx-bar-chart-square",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Apex Charts",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/apex-line-charts",
                            type: "link",
                            title: "Line Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-area-charts",
                            type: "link",
                            title: "Area Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-column-charts",
                            type: "link",
                            title: "Column Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-bar-charts",
                            type: "link",
                            title: "Bar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-mixed-charts",
                            type: "link",
                            title: "Mixed Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-candlestick-charts",
                            type: "link",
                            title: "Candle Stick Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-boxplot-charts",
                            type: "link",
                            title: "Boxplot Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-bubble-charts",
                            type: "link",
                            title: "Bubble Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-scatter-charts",
                            type: "link",
                            title: "Scatter Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/Apex-heatmap-charts",
                            type: "link",
                            title: "Heatmap Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-timeline-charts",
                            type: "link",
                            title: "Timeline Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-treemap-charts",
                            type: "link",
                            title: "Treemap Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-rangearea-charts",
                            type: "link",
                            title: "RangeArea Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-pie-charts",
                            type: "link",
                            title: "Pie Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-radialbar-charts",
                            type: "link",
                            title: "Radialbar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-radar-charts",
                            type: "link",
                            title: "Radar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-polararea-charts",
                            type: "link",
                            title: "Polararea Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/Apex-funnel-charts",
                            type: "link",
                            title: "Funnel Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/chartjs-charts",
                    type: "link",
                    title: "Chartjs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            menuTitle: "MAPS & ICONS"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Maps",
            icon: "bx bx-map",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/google-maps",
                    type: "link",
                    title: "Google Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/leaflet-maps",
                    type: "link",
                    title: "Leaflet Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/vector-maps",
                    type: "link",
                    title: "Jsvector Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),
        new MainMenuItems (
            path: "/icons",
            type: "link",
            icon: "bx bx-store-alt",
            title: "Icons",
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
