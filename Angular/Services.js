function JsonCall(Controller, Action) {
    $.ajax({
        type: "POST",
        traditional: true,
        async: false,
        cache: false,
        url: '/' + Controller + '/' + Action,
        context: document.body,
        success: function (json) {
            list = null; list = json;
        },
        error: function (xhr) {
            list = null;
            //debugger;
        }
    });
}
function JsonCallParam(Controller, Action, Parameters) {
    $.ajax({
        type: "POST",
        traditional: true,
        async: false,
        cache: false,
        url: '/' + Controller + '/' + Action,
        context: document.body,
        data: Parameters,
        success: function (json) {
            list = null; list = json;
        }
   ,
        error: function (xhr) {
            //debugger;
            list = null;
        }
    });
}
//function WebApiCall(Type, Action, Parameters) {

//    $.ajax({
//        type: Type,
//        traditional: true,
//        async: false,
//        cache: false,
//        url: '/api/' + Action,
//        context: document.body,
//        data: Parameters,
//        ContentType: 'application/json;utf-8',
//        success: function (json) {
//            list = json;
//        }
//   ,
//        error: function (xhr) {
//            //debugger;
//        }
//    });
//}
