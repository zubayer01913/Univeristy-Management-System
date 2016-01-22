using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }

        public String Name { get; set; }
        
        //[Required]
        //[RegularExpression(@"^[0-9]{.5,5}$", ErrorMessage = "PhoneNumber should contain only numbers")]

        public float Credit { get; set; }
        public string Descriptio { get; set; }

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public int SemesterID { get; set; }
        public virtual Semester Semester { get; set; }
       
    }
}




//var categoryList = new SelectList(new[] { "SaturDay", "SunDay"," MonDay", "TuesDay", "WesnesDay", "ThursDay", "FriDay"});
//            ViewBag.CategoryList = categoryList;

//  public ActionResult GetCouseCodeList(int id)
//        {
//            var list = db.Courses.Where(x => x.DepartmentID == id).Select(x => new { value = x.Id, Text = x.Name}).ToList();

//            return Json(list);
//        }









//@model UniversityManagementSystem.Models.RoomAllocate

//@{
//    ViewBag.Title = "Create";
//}

//<h2>Create</h2>


//@using (Html.BeginForm()) 
//{
//    @Html.AntiForgeryToken()
    
//    <div class="form-horizontal">
//        <h4>RoomAllocate</h4>
//        <hr />
//        @Html.ValidationSummary(true, "", new { @class = "text-danger" })
//        <div class="form-group">
//            @Html.LabelFor(model => model.DepartmentID, "DepartmentID", htmlAttributes: new { @class = "control-label col-md-2" })
//            <div class="col-md-10">
//                @Html.DropDownList("DepartmentID", null, "Select Department", htmlAttributes: new { @class = "form-control", id = "departmentId" })
//                @*@Html.DropDownList("DepartmentID", null, "Select Department", htmlAttributes: new { @class = "control-label col-md-2", id = "departmentId", })*@
//                @Html.ValidationMessageFor(model => model.DepartmentID, "", new { @class = "text-danger" })
//            </div>
//        </div>

//        <div class="form-group">
//            <p class="control-label col-md-2">Couse Code</p>
//            <div class="col-md-10">
//                <select @Html.EditorFor(model => model.CourseName, new { htmlAttributes = new { @class = "form-control", id = "couseCode" } })></select>
//            </div>
//        </div>

//        <div class="form-group">
//            @Html.LabelFor(model => model.RoomId, "RoomId", htmlAttributes: new { @class = "control-label col-md-2" })
//            <div class="col-md-10">
//                @Html.DropDownList("RoomId", null, htmlAttributes: new { @class = "form-control" })
//                @Html.ValidationMessageFor(model => model.RoomId, "", new { @class = "text-danger" })
//            </div>
//        </div>

//        <div class="form-group">
//            @Html.LabelFor(model => model.DateOfSaven, htmlAttributes: new { @class = "control-label col-md-2" })
//            <div class="col-md-10">
//                @Html.DropDownListFor(model => model.DateOfSaven, (SelectList)ViewBag.CategoryList)
//                @Html.ValidationMessageFor(model => model.DateOfSaven, "", new { @class = "text-danger" })
//            </div>
//        </div>

//        <div class="form-group">
//            @Html.LabelFor(model => model.StartTime, htmlAttributes: new { @class = "control-label col-md-2" })
//            <div class="col-md-10">
//                @Html.EditorFor(model => model.StartTime, new { htmlAttributes = new { @class = "form-control" } })
//                @Html.ValidationMessageFor(model => model.StartTime, "", new { @class = "text-danger" })
//            </div>
//        </div>

//        <div class="form-group">
//            @Html.LabelFor(model => model.Endtime, htmlAttributes: new { @class = "control-label col-md-2" })
//            <div class="col-md-10">
//                @Html.EditorFor(model => model.Endtime, new { htmlAttributes = new { @class = "form-control" } })
//                @Html.ValidationMessageFor(model => model.Endtime, "", new { @class = "text-danger" })
//            </div>
//        </div>

//        <div class="form-group">
//            <div class="col-md-offset-2 col-md-10">
//                <input type="submit" value="Create" class="btn btn-default" />
//            </div>
//        </div>
//    </div>
//}

//<div>
//    @Html.ActionLink("Back to List", "Index")
//</div>

//@section Scripts {
//    @Scripts.Render("~/bundles/jqueryval")
//}
//<script src="~/Scripts/jquery-1.10.2.js"></script>
//<script>

//    $('#departmentId').on("change onmouseover", function () {
//        var id = $('#departmentId').val();
//        console.log(id);
//        $.post("/CourseToTeacherAssign/GetCouseCodeList", { id: id }).success(function (data) {
//            teacher = data;
//            console.log(data);
//            $('#couseCode').empty().append(' <option value="">Please Select a value</option>');
//            data.forEach(function (obj) {
//                // $('#couseCode').append(' <option value="' + obj.value + '">' + obj.Text + '</option>');
//                //$("#selectbox").val(obj.value).attr('selected', true);

//                $('#couseCode').append($('<option>', {
//                    value: obj.value,
//                    text: obj.Text,
//                    //credit: boj.creditNo
//                }));
//            });


//        });
//    });


//</script>
