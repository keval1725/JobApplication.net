let ActionDropDown = document.querySelectorAll(".ActionDropDown");
console.log(ActionDropDown)


ActionDropDown.forEach((i) => {

    i.addEventListener("change", () => {
        let optArr = i.options;
        for (i = 0; i < optArr.length; i++) {
            if (optArr[i].selected) {
                if (optArr[i].value.includes("Update")) {
                    window.location.assign(`/JobApplication/${optArr[i].value}`);
                } else if (optArr[i].value.includes("Delete")) {
                    window.location.assign(`/JobApplication/${optArr[i].value}`);

                }
            }
        }
    })
});

function ShowData() {

    let dataAdd = document.getElementById("List_data");
    console.log(dataAdd);


    let formData = {
        searchValue: $("#Searching").val(),

    }
    console.log($("#Searching").val());

    $.ajax({
        url: `/JobApplication/List?serch=${Searching.value}`,
        type: "GET",
        data: formData,
        success: function (data) {
            console.log(data)

            let str = "";
            let arr = data.listModel.basicDetailes;
            console.log(arr);

            //let pageCount = data.listModel.pagecount;

            console.log(arr);


            dataAdd.innerHTML = "";
            str += `<table class="table-active table">
        <thead>
            <tr>
                <th>
                   Sr.No

                </th>
                    <th>
                            <a href="List?columnOrder=${data.firstName}&&searchFor=${data.currentSearch}">

                           FirstName
                    </a>
        </th>
        <th>
                        <a href="List?columnOrder=${data.lastName}&&searchFor=${data.currentSearch}">
                   LastName
                    </a>
        </th>
        <th>
                        <a href="List?columnOrder=${data.emailId}&&searchFor=${data.currentSearch}">
                 Email
                    </a>
        </th>
        <th>
                        <a href="List?columnOrder=${data.gender}&&searchFor=${data.currentSearch}">
                  Gender
                    </a>
        </th>
        <th>
                        <a href="List?columnOrder=${data.City}&&searchFor=${data.currentSearch}">
                   City
                    </a>
        </th>
               <th>
               Actions
               </th>
            

            </tr>
        </thead>
        `   


            let count = 1;
            arr.forEach((i) => {

                str += `
                     <tr>
                        <td>
                       ${count}
                        </td>
                        <td>
                       ${i.firsT_NAME}
                        </td>
                        <td>
                       ${i.lasT_NAME}
                        </td>
                        <td>
                       ${i.email}
                        </td>
                        <td>
                       ${i.gender}
                        </td>
                        <td>
                       ${i.city}
                        </td>
                       <td>
                <select class="form-control dropdown ActionDropDown">

                    <option disabled="disabled" selected>Action</option>
                    <option value="Update/${i.basic_id}">
                        <a href="Update?id=${i.basic_id}">Update</a>
                       
                    </option>
                    <option value="Delete/${i.basic_id}">
                        <a href="Delete?id=${i.basic_id}">Delete</a>
                    </option>

                </select>


            </td>
                    
            </tr>`;

                count++;

            });


            str += `</tbody>
                        </table>`
            console.log(str);
            dataAdd.innerHTML = str;

            let ActionDropDown = document.querySelectorAll(".ActionDropDown");
            console.log(ActionDropDown)


            ActionDropDown.forEach((i) => {

                i.addEventListener("change", () => {
                    let optArr = i.options;
                    for (i = 0; i < optArr.length; i++) {
                        if (optArr[i].selected) {
                            if (optArr[i].value.includes("Update")) {
                                window.location.assign(`/JobApplication/${optArr[i].value}`);
                            } else if (optArr[i].value.includes("Delete")) {
                                window.location.assign(`/JobApplication/${optArr[i].value}`);

                            }
                        }
                    }
                })
            });

        },
        Error: function (request, status, error) {
            alert(request.responseText);
        }
    });
}

   
