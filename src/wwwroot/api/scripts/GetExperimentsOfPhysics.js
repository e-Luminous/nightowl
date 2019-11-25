$(document).ready(function () {
    var studentId = $('#StudentIdFromViewBag').val();
    var classroomId = $('#ClassroomIdFromViewBag').val();

    $.get('/Classrooms/GetPhysicsSubmissionOfTheStudent', { studentId: studentId, classroomId : classroomId }, function(data) {
        for (var i=0; i< data.length; i++){
            window[data[i]["experiment"]["scriptFunctionToEvaluateExperiment"]](data[i]["experiment"], data[i]);
        }
    });
});


/* Exp Phy 01 */
function InitiatePhy01(experiment, submission) {
    var exp01 = JSON.parse(experiment["experimentalTableJsonStructure"]);
    var submissionAPI = JSON.parse(submission["apiData"]);

    var exp01Table = $('#exp01Table');
    if(submissionAPI == null){
        var columns = setHeaders(exp01, exp01Table);
        setBody(columns, exp01Table, exp01);
    }
    else {
        var columns = setHeaders(submissionAPI, exp01Table);
        setBody(columns, exp01Table, submissionAPI);
    }
    
    $('#exp01Table td').attr('contenteditable','true');
}

/* Exp Phy 02 */
function InitiatePhy02(experiment, submission) {
    var exp02 = JSON.parse(experiment["experimentalTableJsonStructure"]);
    var submissionAPI = JSON.parse(submission["apiData"]);

    var exp02Table = $('#exp02Table');
    if(submissionAPI == null){
        var columns = setHeaders(exp02, exp02Table);
        setBody(columns, exp02Table, exp02);
    }
    else {
        var columns = setHeaders(submissionAPI, exp02Table);
        setBody(columns, exp02Table, submissionAPI);
    }

    $('#exp02Table td').attr('contenteditable','true');
}

/* Exp Phy 03 */
function InitiatePhy03(experiment, submission) {
    var exp03 = JSON.parse(experiment["experimentalTableJsonStructure"]);
    var submissionAPI = JSON.parse(submission["apiData"]);
 
    var exp03Table = $('#exp03Table');
    if(submissionAPI == null){
        var columns = setHeaders(exp03, exp03Table);
        setBody(columns, exp03Table, exp03);
    }
    else {
        var columns = setHeaders(submissionAPI, exp03Table);
        setBody(columns, exp03Table, submissionAPI);
    }
    
    $('#exp03Table td').attr('contenteditable','true');
}

/* Exp Phy 04 */
function InitiatePhy04(experiment, submission) {
    var exp04 = JSON.parse(experiment["experimentalTableJsonStructure"]);
    var submissionAPI = JSON.parse(submission["apiData"]);

    var exp04Table = $('#exp04Table');
    if(submissionAPI == null){
        var columns = setHeaders(exp04, exp04Table);
        setBody(columns, exp04Table, exp04);
    }
    else {
        var columns = setHeaders(submissionAPI, exp04Table);
        setBody(columns, exp04Table, submissionAPI);
    }
    
    $('#exp04Table td').attr('contenteditable','true');
}

/* Exp Phy 05 */
function InitiatePhy05(experiment, submission) {
    var exp05 = JSON.parse(experiment["experimentalTableJsonStructure"]);
    var submissionAPI = JSON.parse(submission["apiData"]);
 
    var exp05Table = $('#exp05Table');
    if(submissionAPI == null){
        var columns = setHeaders(exp05, exp05Table);
        setBody(columns, exp05Table, exp05);
    }
    else {
        var columns = setHeaders(submissionAPI, exp05Table);
        setBody(columns, exp05Table, submissionAPI);
    }
    
    $('#exp05Table td').attr('contenteditable','true');
}


/* Exp Phy 06 */
function InitiatePhy06(experiment, submission) {
    var exp06 = JSON.parse(experiment["experimentalTableJsonStructure"]);
    var submissionAPI = JSON.parse(submission["apiData"]);
    
    var exp06Table = $('#exp06Table');
    if(submissionAPI == null){
        var columns = setHeaders(exp06, exp06Table);
        setBody(columns, exp06Table, exp06);
    }
    else {
        var columns = setHeaders(submissionAPI, exp06Table);
        setBody(columns, exp06Table, submissionAPI);
    }

    $('#exp06Table td').attr('contenteditable','true');
}

/* Exp Phy 07 */
function InitiatePhy07(experiment, submission) {
    var exp07 = JSON.parse(experiment["experimentalTableJsonStructure"]);
    var submissionAPI = JSON.parse(submission["apiData"]);
    
    var exp07Table = $('#exp07Table');
    if(submissionAPI == null){
        var columns = setHeaders(exp07, exp07Table);
        setBody(columns, exp07Table, exp07);
    }
    else {
        var columns = setHeaders(submissionAPI, exp07Table);
        setBody(columns, exp07Table, submissionAPI);
    }

    $('#exp07Table td').attr('contenteditable','true');
}



/* Set All Table Header */
function setHeaders(list, expTable) { 
    var columns = []; 
    var header = $('<tr/>'); 
    
    for (var each in list[0]) { 
        if ($.inArray(each, columns) == -1) { 
            columns.push(each); 
            //console.log("Each col Name " + each);
            // Creating the header 
            header.append($('<th/>').html(each)); 
        } 
    } 
    
    // Appending the header to the table 
    $(expTable).append(header); 
    return columns;
}	 


/* Set All Body Info */
function setBody(columns, expTable, exp) { 

    // Traversing the JSON data 
    for (var i = 0; i < exp.length; i++) { 
        var row = $('<tr/>'); 
        for (var colIndex = 0; colIndex < columns.length; colIndex++) 
        { 
            var val = exp[i][columns[colIndex]]; 
            
            //console.log("val : " + val + " size : " + val.length);

            if(columns[0] === "চাপ" && colIndex == 0) {
                var radioString = ' ';

                console.log("Nth radio checked : " + val);

                if(val == 0){
                    radioString += '<label><input type="radio" name="group'+i+'" checked/> <span>বায়ু মন্ডলের চাপ</span> </label>' + '<br>';
                    radioString += '<label><input type="radio" name="group'+i+'"/> <span>বায়ু মন্ডলের চাপের বেশী</span> </label>' + '<br>';
                    radioString += '<label><input type="radio" name="group'+i+'"/> <span>বায়ু মন্ডলের চাপের কম</span> </label>';
                }
                else if(val == 1){
                    radioString += '<label><input type="radio" name="group'+i+'"/> <span>বায়ু মন্ডলের চাপ</span> </label>' + '<br>';
                    radioString += '<label><input type="radio" name="group'+i+'" checked/> <span>বায়ু মন্ডলের চাপের বেশী</span> </label>' + '<br>';
                    radioString += '<label><input type="radio" name="group'+i+'"/> <span>বায়ু মন্ডলের চাপের কম</span> </label>';
                }
                else if(val == 2){
                    radioString += '<label><input type="radio" name="group'+i+'"/> <span>বায়ু মন্ডলের চাপ</span> </label>'+'<br>';
                    radioString += '<label><input type="radio" name="group'+i+'"/> <span>বায়ু মন্ডলের চাপের বেশী</span> </label>' + '<br>';
                    radioString += '<label><input type="radio" name="group'+i+'" checked/> <span>বায়ু মন্ডলের চাপের কম</span> </label>';
                }

                console.log(radioString);
                row.append($('<tr/>').html(radioString));
                continue;
            }

            if(columns[0] === "ব্যবস্থা" && colIndex == 0) {
                var radioString = ' ';

                if(val == 0){
                    radioString += '<label><input type="radio" name="typeOf'+i+'" checked/> <span>লম্বিক ব্যবস্থা</span> </label>' + '<br>';
                    radioString += '<label><input type="radio" name="typeOf'+i+'"/> <span>আড়াআড়ি ব্যবস্থা</span> </label>' + '<br>';
                }
                else if(val == 1){
                    radioString += '<label><input type="radio" name="typeOf'+i+'" /> <span>লম্বিক ব্যবস্থা</span> </label>' + '<br>';
                    radioString += '<label><input type="radio" name="typeOf'+i+'" checked/> <span>আড়াআড়ি ব্যবস্থা</span> </label>' + '<br>';
                }
                
                row.append($('<tr/>').html(radioString));
                continue;
            }

            if(val.length > 0) {
                var subRow = $("<tr/>");
                val.forEach(element => {
                    subRow.append($('<tr/>').html(element)); 
                });
                row.append($('<td/>').html(subRow));
                continue;
            }

            if (val == null) val = ""; 
                row.append($('<td/>').html(val)); 
            
        } 
        
        // Adding each row to the table 
        $(expTable).append(row); 
    }
     
} 