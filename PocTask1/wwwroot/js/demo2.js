var newk = @newk;

function addDelete(id) {

    console.log(id);
    $("#" + id).html("");
}


function addServiceInEdit(newj) {

    ++newk;
    var sam = newk + 1;
    var d = document.getElementById(newj);

    d.innerHTML += `<div id="${newj}${newk}"><p><b>Service ${sam}</b></p>
                    <div class="form-group row ">
                        <div class="col-md-2">
                            Description
                        </div>
                        <div class="col-md-9 px-5">
                            <input input type="text" name="applications[${newj}].Services[${newk}].Description" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group row ">
                        <div class="col-md-2">
                             Endpoint
                        </div>
                        <div class="col-md-9 px-5">
                            <input input type="text" name="applications[${newj}].Services[${newk}].Endpoint" class="form-control" /><span asp-validation-for="applications[@newj].Services[${newk}].Endpoint" class="text-danger"></span>
                        </div>
                    </div>
                    <div class="form-group row ">
                        <div class="col-md-2">
                            Template
                        </div>
                        <div class="col-md-9 px-5">
                            <input input type="text" name="applications[${newj}].Services[${newk}].Template" class="form-control" />

                        </div>
                    </div>
                    <div class="form-group row ">
                        <div class="col-md-2">
                             Time
                        </div>
                        <div class="col-md-9 px-5">
                            <input input type="text" name="applications[${newj}].Services[${newk}].Time" class="form-control" />

                        </div>
                    </div>

                    <button class="" onclick="addDelete('${newj}${newk}')" type="button">Delete Service</button>
                    <br/>
                     </div>`;

}