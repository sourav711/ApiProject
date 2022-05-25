const url='https://localhost:44330/api/PlayersInfo';
document.getElementById('btn1').addEventListener('click',getData);
function getData(){
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
      };
      
      fetch("https://localhost:44330/api/PlayersInfo", requestOptions)
        .then(response => response.text())
        .then(result => showData(result))
        .catch(error => console.log('error', error));}
function showData(data) {
    document.getElementById('div1').innerHTML = data;
//   _displayCount(data.length);
}


document.getElementById('btn2').addEventListener('click',oneRecord);
 function oneRecord(){
     var id=document.getElementById("inp").value;
     var url="https://localhost:44330/api/PlayersInfo/"+id;
    fetch(url)
    .then(response => response.text())
    .then(result => showRecord(result))
    .catch(error => console.log('error', error));}
function showRecord(data) {
document.getElementById('div1').innerHTML = data;
}


function sendJSON(){

 let PlayersName = document.getElementById("title");

    let PlayerAge = document.getElementById("age");

    let PlayerRole = document.getElementById("role");
    let PlayerMatches=document.getElementById("matches");
    let result=document.getElementById('div1');

    // Creating a XHR object
    let xhr = new XMLHttpRequest();

    let url = "https://localhost:44330/api/PlayersInfo";
 // open a connection
    xhr.open("POST", url, true);
 // Set the request header i.e. which type of content you are sending

    xhr.setRequestHeader("Content-Type", "application/json");
 // Create a state change callback

    xhr.onreadystatechange = function () {

        if (xhr.readyState === 4 && xhr.status === 200) {

            result.innerHTML = this.responseText;



        }

    };



    // Converting JSON data to string

    var data = JSON.stringify({  "playerName": PlayersName.value , "playerAge":PlayerAge.value, "playerRole":PlayerRole.value ,"playerMatches":PlayerMatches.value});
  // Sending data with the request

    xhr.send(data);

}
function getitems3() {

   

    var id=document.getElementById("like").value;

    var url="https://localhost:44330/api/PlayersInfo/"+id;

    fetch(url)

    .then((res) => res.text())

    .then(ans => showData(ans))  

    }

  function showData(data)

  {

      document.getElementById('div1').innerHTML=data;

  }


// document.getElementById('btn3').addEventListener('click',getData2);
// function getData2(){
//     var fname=document.getElementById("title").value;
//     var age=document.getElementById("age").value;
//     var role=document.getElementById("role").value;
//     var matches=document.getElementById("matches").value;

//     const jsonn={
//         "playerName": fname,
//         "playerAge": age,
//         "playerRole":role,
//         "playerMatches":matches
//     };
// var requestOptions = {
//   method: 'POST',
//   redirect: 'follow',
//   body: JSON.parse(jsonn),

// };

// fetch("https://localhost:44330/api/PlayersInfo", requestOptions)
//   .then(response => response.text())
//   .then(result => console.log(result))
//   .catch(error => console.log('error', error));
//     const jsonn={
//         "playerName": fname,
//         "playerAge": age,
//         "playerRole":role,
//         "playerMatches":matches
//     };
//     var requestOptions = {
//         method: 'POST',
//         body: JSON.parse(jsonn),
//         headers: {
//             "Content-type": "application/json; charset=UTF-8",
//            "Access-Control-Allow-Origin": "*"
            
//         } };
//         console.log(body);
//       fetch("https://localhost:44330/api/PlayersInfo/post", requestOptions)
//         .then(response => response.text())
//         .then(result => showData(result))
//         .catch(error => console.log('error', error));
//     }
// function showData(data) {
//     document.getElementById('div1').innerHTML = data;
//   _displayCount(data.length);
//}


// fetch("https://jsonplaceholder.typicode.com/posts", {
     
//     // Adding method type
//     method: "POST",
     
//     // Adding body or contents to send
//     body: JSON.stringify({
//         title: "foo",
//         body: "bar",
//         userId: 1
//     }),
     
//     // Adding headers to the request
//     headers: {
//         "Content-type": "application/json; charset=UTF-8"
//     }
// })
 
// // Converting to JSON
// .then(response => response.json())
 
// // Displaying results to console
// .then(json => console.log(json));