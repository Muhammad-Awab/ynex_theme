
public class TaskListService
{
    private List<TaskList> TaskLists = new List<TaskList>()
    {
        new TaskList { 
            TaskName = "Design New Landing Page", 
            TaskListId = "SPK - 01", 
            AssignedDate = "02-06-2023", 
            Status = "New",       
            StatusColor="primary", 
            Priority = "Medium",
            PriorityColor="secondary", 
            DueDate = "10-06-2023", 
            AssignedTo = new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/5.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/3.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/2.jpg"}
            }
        },
        new TaskList { 
            TaskName = "New Project Buleprint",
            TaskListId = "SPK - 04", 
            AssignedDate = "05-06-2023", 
            Status = "Inprogress",
            StatusColor="secondary",
            Priority = "High", 
            PriorityColor="danger", 
            DueDate = "15-06-2023",
            AssignedTo = new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/10.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/9.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/7.jpg"}
            }
        },
        new TaskList { 
            TaskName = "Server Side Validation",             
            TaskListId = "SPK - 11", 
            AssignedDate = "12-06-2023", 
            Status = "Pending",   
            StatusColor="warning", 
            Priority = "Low",    
            PriorityColor="success", 
            DueDate = "16-06-2023",
            AssignedTo = new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/5.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/9.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/13.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/10.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/9.jpg"}
            }
        },
        new TaskList { 
            TaskName = "New Plugin Development",
            TaskListId = "SPK - 24", 
            AssignedDate = "08-06-2023", 
            Status = "Completed", 
            StatusColor="success", 
            Priority = "Low",    
            PriorityColor="success", 
            DueDate = "17-06-2023" ,
            AssignedTo = new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/5.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/1.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/2.jpg"}
            }
        },
        new TaskList { 
            TaskName = "Designing New Authentication Page",  
            TaskListId = "SPK - 16", 
            AssignedDate = "03-06-2023", 
            Status = "Inprogress",
            StatusColor="secondary",
            Priority = "Medium",
            PriorityColor="secondary", 
            DueDate = "08-06-2023" ,
            AssignedTo = new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/10.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/15.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
            }
        },
        new TaskList { 
            TaskName = "Documentation For New Template",     
            TaskListId = "SPK - 07", 
            AssignedDate = "12-06-2023", 
            Status = "New",       
            StatusColor="primary", 
            Priority = "High",   
            PriorityColor="danger", 
            DueDate = "25-06-2023",
            AssignedTo =new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
            } 
        },
        new TaskList { 
            TaskName = "Updating Old UI",                    
            TaskListId = "SPK - 13", 
            AssignedDate = "06-06-2023", 
            Status = "Completed", 
            StatusColor="success", 
            Priority = "Low",    
            PriorityColor="success", 
            DueDate = "12-06-2023",
            AssignedTo =new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/1.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/10.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
            } 
        },
        new TaskList { 
            TaskName = "Developing New Events In Plugins",   
            TaskListId = "SPK - 20", 
            AssignedDate = "14-06-2023", 
            Status = "Pending",   
            StatusColor="warning", 
            Priority = "High",   
            PriorityColor="danger", 
            DueDate = "19-06-2023",
            AssignedTo =new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/3.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/9.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
            } 
        },
        new TaskList { 
            TaskName = "Fixing Minor Ui Issues",             
            TaskListId = "SPK - 26", 
            AssignedDate = "11-06-2023", 
            Status = "Completed", 
            StatusColor="success", 
            Priority = "Medium", 
            PriorityColor="secondary", 
            DueDate = "18-06-2023",
            AssignedTo =new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/5.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/14.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/3.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/1.jpg"}
            }
        },
        new TaskList { 
            TaskName = "Designing Of New Ecommerce Website", 
            TaskListId = "SPK - 32", 
            AssignedDate = "03-06-2023", 
            Status = "Inprogress",
            StatusColor="secondary",
            Priority = "Low",   
            PriorityColor="success", 
            DueDate = "09-06-2023",
            AssignedTo =new List<AssignedToItem>
            {
                new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/6.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/5.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/3.jpg"},
                new AssignedToItem { Img = "../assets/images/faces/1.jpg"}
            } 
        },
    };

    public List<TaskList> GetTaskLists()
    {
        return TaskLists;
    }

    public async Task DeleteTaskList(string? TaskListId)
    {
        var TaskListToDelete = TaskLists.FirstOrDefault(i => i.TaskListId == TaskListId);
        if (TaskListToDelete != null)
        {
            TaskLists.Remove(TaskListToDelete);
            await Task.Delay(1000);
        }
    }
}
