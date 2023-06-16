document.addEventListener("DOMContentLoaded", () => {
    document.querySelectorAll(".arrDropDown").forEach((i) => {
        i.removeAttribute("multiple");
    })
});
 let arr = [];
let pref_loc = document.getElementById("pref_loc");
document.querySelectorAll(".prefrence_num").length;
    
function prefrence_num(ar) {
    arr.push(ar.value);

    for (let i = 0; i < arr.length-1; i++) {
        if (arr.length > 3) {
            break
        } else {

      pref_loc.innerHTML += `${i+1}:-${arr[i]} ,`;

        }
  
    }
    console.log(arr
    );
}

// parent nodes
let parent_edu = document.getElementById("parent_edu");
let parent_lang = document.getElementById("parent_lang");
let parent_ref = document.getElementById("parent_ref");
let parent_work = document.getElementById("parent_work");
let parent_tech = document.getElementById("parent_tech");
let parent_prefer_tr = document.getElementById("prefer_tr");

// child nodes
let child_edu = document.getElementById("child_edu");
let child_work = document.getElementById("child_work");
let child_lang = document.getElementById("child_lang");
let child_tech = document.getElementById("child_tech");
let child_ref = document.getElementById("child_ref");
let locations = document.getElementById("location1");
// button nodes
let edu = document.getElementById('edu');
let reference = document.getElementById('reference');
let techno = document.getElementById('techno');
let lang = document.getElementById('lang');
let exp = document.getElementById('exp') ;
let pf = document.getElementById("pbtn");
let edu_count = 0;
let id = 0;
edu.addEventListener("click", () => {

    id++;
    edu_count++;

    let temp = edu_count;
    
    let new_clone = child_edu.cloneNode(true);
   
    let edu_Course = document.getElementById("edu_Course");
    edu_Course.setAttribute("name", `BasicDetailes.Educations[${temp}].Course`);


    let edu_Institute = document.getElementById("edu_Institute")
    edu_Institute.setAttribute("name", `BasicDetailes.Educations[${temp}].Board`)

    let edu_PassYear = document.getElementById("edu_PassYear")
    edu_PassYear.setAttribute("name", `BasicDetailes.Educations[${temp}].PassYear`)

    let edu_Grade = document.getElementById("edu_Grade")

    edu_Grade.setAttribute("name", `BasicDetailes.Educations[${temp}].Percentage`)

    let new_row = parent_edu.appendChild(new_clone);
  
    new_row.removeAttribute("id");
    new_row.setAttribute("id", `child_edu_${id}`);

    console.log(new_row.childNodes);

}); 
let prefers = 0;

pf.addEventListener("click", () => {

    let new_clone = locations.cloneNode(true);
    //let edu_Course = document.getElementById("edu_Course");
    //edu_Course.setAttribute("name", `BasicDetailes.Educations[${temp}].Course`);
    let new_row = parent_prefer_tr.appendChild(new_clone);
    console.log(new_row);


})







let ref_count = 0;
reference.addEventListener("click", () => {

    ref_count++;

    let temp = ref_count;

    let new_clone = child_ref.cloneNode(true);

    let refrence_ReferencePersonName = document.getElementById("refrence_ReferencePersonName");
    refrence_ReferencePersonName.setAttribute("name", `BasicDetailes.Refrences[${temp}].ReferencePersonName`);
    //refrence_ReferencePersonName.setAttribute("id", `References[${temp}].ReferencePersonName`)

    let refrence_ReferencePersonContact = document.getElementById("refrence_ReferencePersonContact")
    refrence_ReferencePersonContact.setAttribute("name", `BasicDetailes.Refrences[${temp}].ReferencePersonContact`)
    //refrence_ReferencePersonContact.setAttribute("id", `References[${temp}].ReferencePersonContact`)

    let refrence_RefrencePersonRelation = document.getElementById("refrence_RefrencePersonRelation")
    refrence_RefrencePersonRelation.setAttribute("name", `BasicDetailes.Refrences[${temp}].RefrencePersonRelation`)
    //refrence_RefrencePersonRelation.setAttribute("id", `References[${temp}].RefrencePersonRelation`)



    let new_row = parent_ref.appendChild(new_clone);


});

let exp_count = 0;
exp.addEventListener("click", () => {


    exp_count++;

    let temp = exp_count;

    let new_clone = child_work.cloneNode(true);

    let work_Company = document.getElementById("work_Company");
    work_Company.setAttribute("name", `BasicDetailes.WorkExperinces[${temp}].Company_name`);


    let work_Role = document.getElementById("work_Role")
    work_Role.setAttribute("name", `BasicDetailes.WorkExperinces[${temp}].DESIGNATION`)


    let work_From = document.getElementById("work_From")
    work_From.setAttribute("name", `BasicDetailes.WorkExperinces[${temp}].From"`)


    let work_To = document.getElementById("work_To")
    work_To.setAttribute("name", `BasicDetailes.WorkExperience[${temp}].To`)



    let new_row = parent_work.appendChild(new_clone);


});




document.querySelectorAll(" .LanguageName").forEach((i) => {
    let read = document.getElementById(`Read_${i.value}`);
    let write = document.getElementById(`Write_${i.value}`);
    let speak = document.getElementById(`Speak_${i.value}`);

    read.disabled = true;
    write.disabled = true;
    speak.disabled = true;

    i.addEventListener("click", () => {

        if (i.checked) {

            read.disabled = false;
            write.disabled = false;
            speak.disabled = false;

        } else {
            if (read.checked || write.checked || speak.checked) {
                read.checked = false;
                write.checked = false;
                speak.checked = false;
            }
            read.disabled = true;
            write.disabled = true;
            speak.disabled = true;
        }
    })
})



document.querySelectorAll(" .TechnologyName").forEach((i) => {

    let beginer = document.getElementById(`Beigner(${i.value})`);
    let mideator = document.getElementById(`Mediatr(${i.value})`);
    let expert = document.getElementById(`Expert(${i.value})`);

    beginer.disabled = true;
    mideator.disabled = true;
    expert.disabled = true;

    i.addEventListener("click", () => {
        if (i.checked) {

            beginer.disabled = false;
            mideator.disabled = false;
            expert.disabled = false;

        } else {
            if (beginer.checked || mideator.checked || expert.checked) {
                beginer.checked = false;
                mideator.checked = false;
                expert.checked = false;
            }
            beginer.disabled = true;
            mideator.disabled = true;
            expert.disabled = true;
        }
    })

})





function runTimeChanges() {
 
    let count = 0;
    let languagesList = document.querySelectorAll(".LanguageName");

    languagesList.forEach(j => {

        console.log("this is executed");
        let read = document.getElementById(`Read_${j.value}`);
        let write = document.getElementById(`Write_${j.value}`);
        let speak = document.getElementById(`Speak_${j.value}`);

        if (j.checked) {


            j.setAttribute("name", `BasicDetailes.Langauges[${count}].langauge`);
            read.setAttribute("name", `BasicDetailes.Langauges[${count}].Read`)
            write.setAttribute("name", `BasicDetailes.Langauges[${count}].Write`)
            speak.setAttribute("name", `BasicDetailes.Langauges[${count}].Speak`)


            count++;
        } else {
            j.removeAttribute("name");
            read.removeAttribute("name")
            write.removeAttribute("name")
            speak.removeAttribute("name")
        }
    })

    let counter = 0;
    let technologyList = document.querySelectorAll(".TechnologyName");
    technologyList.forEach((k) => {

        console.log("this is executed");
        let beginer = document.getElementById(`Beigner(${k.value})`);
        let mideator = document.getElementById(`Mediatr(${k.value})`);
        let expert = document.getElementById(`Expert(${k.value})`);
        if (k.checked) {

            k.setAttribute("name", `BasicDetailes.Technologiess[${counter}].TechnologyName`);
            beginer.setAttribute("name", `BasicDetailes.Technologiess[${counter}].TechLevel`)
            mideator.setAttribute("name", `BasicDetailes.Technologiess[${counter}].TechLevel`)
            expert.setAttribute("name", `BasicDetailes.Technologiess[${counter}].TechLevel`)


            counter++;
        } else {
            k.removeAttribute("name");
            beginer.removeAttribute("name")
            mideator.removeAttribute("name")
            expert.removeAttribute("name")
        }
    })


}


function SubmitConfirmation() {

    let text = "Do you Want To Submit This....??";
    if (confirm(text)) {
        runTimeChanges();


        alert("your form submitted successfully!!")
        runTimeChanges();
        setTimeout(() => {
            return true;
        }, 10000)


    } else {
        runTimeChanges();
        return false;
    }
}
