

const url = "https://localhost:44305/api/account";
let giris = document.getElementById("giris");
let btn =document.getElementById("bas");
let counter = 1;

const token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJoZXNlbjEyMyIsIlRlc3QiOiJsb3JlbSBpcHN1bSIsIm5iZiI6MTY2MTA3NzAyNSwiZXhwIjoxNjYxMDg3ODI1LCJpYXQiOjE2NjEwNzcwMjV9.5xc3kYXpPJq3YnucyR1zCxwWr_tYSOGT6Sec7cvx4FwNjcSFIrKxW-xwSC4XKf6MI6Bazg8irm1s2gCNzYEtPw"
const config = {
  headers: { Authorization: `Bearer ${token}` }
 
};


btn.addEventListener("click",function(){
    axios.get(url,config)
    })
    .then(function (response) {
      
      

    const data = response.data;   
    data.forEach(element => {
        const newTr = document.createElement("tr");
        const newTh = document.createElement("th");
        const newTd = document.createElement("td");
        const newTd2 = document.createElement("td");

        newTh.innerHTML=counter++;
        newTd.innerHTML=element.username;
        newTd2.innerHTML=element.token.substring(60,70);

        newTr.appendChild(newTh);
        newTr.appendChild(newTd);
        newTr.appendChild(newTd2);
        giris.appendChild(newTr);
        console.log(element.username)
    });
  });


