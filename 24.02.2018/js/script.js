var cityInput = document.querySelector(".city");
var addBtn = document.querySelector(".add");
var seher = document.querySelector(".seher");


addBtn.addEventListener("click",function(){
    if(cityInput.value !=""){
        var li = document.createElement("li");

        var icon = document.createElement("i");
        icon.classList.add("fas");
        icon.classList.add("fa-times");

        icon.addEventListener("click",function(){
            this.parentNode.remove();
        });
        
        li.innerHTML = cityInput.value;
        li.appendChild(icon);

        seher.appendChild(li);
        cityInput.value = "";
    }
});