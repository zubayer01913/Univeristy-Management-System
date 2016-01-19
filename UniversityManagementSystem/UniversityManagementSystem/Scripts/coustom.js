
    //var teacher = [];
    $('#departmentId').on("change onmouseover", function () {
        var id = $('#departmentId').val();
        console.log(id);
        $.post("/CourseToTeacherAssign/GetTeacherList", { id: id }).success(function (data) {
            teacher = data;
            console.log(data);
            $('#teacherId').empty().append(' <option value="">Please Select a value</option>');
            data.forEach(function (obj)
            {
                //$('#teacherId').append(' <option value="' + obj.value + '">' + obj.Text + '</option>');
                //$("#selectbox").val(obj.value).attr('selected', true);
                $('#teacherId').append($('<option>', {
                    value: obj.value,
                    text: obj.Text,
                    credit: obj.credit
                }));
            });


        });
    });

$('#teacherId').on("change ", function ()
{
    $('#creditTaken').val(
                            $('#teacherId option:selected').attr('credit')
                         );
});



$('#departmentId').on("change onmouseover", function () {
    var id = $('#departmentId').val();
    console.log(id);
    $.post("/CourseToTeacherAssign/GetCouseCodeList", { id: id }).success(function (data) {
        teacher = data;
        console.log(data);
        $('#couseCode').empty().append(' <option value="">Please Select a value</option>');
        data.forEach(function (obj) {
            $('#couseCode').append(' <option value="' + obj.value + '">' + obj.Text + '</option>');
            //$("#selectbox").val(obj.value).attr('selected', true);
        });


    });
});

//$('#couseCode').on("change onmouseover", function () {
//    var id = $('#couseCode').val();
//    console.log(id);
//    $.post("/CourseToTeacherAssign/GetCouseNameList", { id: id }).success(function (data) {
//        teacher = data;
//        console.log(data);
//        $('#couseName').empty().append(' <option value="">Please Select a value</option>');
//        data.forEach(function (obj) {
//            $('#couseName').append(' <option value="' + obj.value + '">' + obj.Text + '</option>');
//            //$("#selectbox").val(obj.value).attr('selected', true);
//        });


//    });
//});

//$('#couseName').on("change onmouseover", function () {
//    var id = $('#couseName').val();
//    console.log(id);
//    $.post("/CourseToTeacherAssign/GetCouseCreditList", { id: id }).success(function (data) {
//        teacher = data;
//        console.log(data);
//        $('#credit').empty().append(' <option value="">Please Select a value</option>');
//        data.forEach(function (obj) {
//            $('#credit').append(' <option value="' + obj.value + '">' + obj.Text + '</option>');
//            //$("#selectbox").val(obj.value).attr('selected', true);
//        });


//    });
//});