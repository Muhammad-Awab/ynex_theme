(function () {
    "use strict"

    var drag = dragula([document.querySelector('#new-tasks-draggable'), document.querySelector('#todo-tasks-draggable'), document.querySelector('#inprogress-tasks-draggable'), document.querySelector('#inreview-tasks-draggable'), document.querySelector('#completed-tasks-draggable')]);
    
    drag.on('dragend', function(el) {
        
        let i = [
            document.querySelector('#new-tasks-draggable'),
            document.querySelector('#todo-tasks-draggable'),
            document.querySelector('#inprogress-tasks-draggable'),
            document.querySelector('#inreview-tasks-draggable'),
            document.querySelector('#completed-tasks-draggable')

        ]
        i.map((ele) => {
            if (ele) {
                // console.log("ddd");
                if (ele.children.length == 0) {
                    ele.classList.add("task-Null")
                    document.querySelector(`#${ele.getAttribute("data-view-btn")}`).nextElementSibling?.classList.add("d-none")
                }
                if (ele.children.length != 0) {
                    ele.classList.remove("task-Null")
                    document.querySelector(`#${ele.getAttribute("data-view-btn")}`).nextElementSibling?.classList.remove("d-none")
                }
            }
        })
    });


   
    document.addEventListener("DOMContentLoaded", () => {
            let i = [
                document.querySelector('#new-tasks-draggable'),
                document.querySelector('#todo-tasks-draggable'),
                document.querySelector('#inprogress-tasks-draggable'),
                document.querySelector('#inreview-tasks-draggable'),
                document.querySelector('#completed-tasks-draggable')

            ]
            i.map((ele) => {
                if (ele) {
                    // console.log("ddd");
                    if (ele.children.length == 0) {
                        ele.classList.add("task-Null")
                        document.querySelector(`#${ele.getAttribute("data-view-btn")}`).nextElementSibling?.classList.add("d-none")
                    }
                    if (ele.children.length != 0) {
                        ele.classList.remove("task-Null")
                        document.querySelector(`#${ele.getAttribute("data-view-btn")}`).nextElementSibling?.classList.remove("d-none")
                    }
                }
            })
    })

     /* filepond */
     FilePond.registerPlugin(
        FilePondPluginImagePreview,
        FilePondPluginImageExifOrientation,
        FilePondPluginFileValidateSize,
        FilePondPluginFileEncode,
        FilePondPluginImageEdit,
        FilePondPluginFileValidateType,
        FilePondPluginImageCrop,
        FilePondPluginImageResize,
        FilePondPluginImageTransform
    );

    /* multiple upload */
    const MultipleElement = document.querySelector('.multiple-filepond');
    FilePond.create(MultipleElement,);

})();