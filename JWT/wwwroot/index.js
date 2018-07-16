$(function(){

    $.ajax({
        type: "GET",
        //data: $.toJSON(objParams),
        url: '/api/values',
        // headers: {
        //     "Authorization":"Bearer "
        // },
        beforeSend: function(xhr) {
            xhr.setRequestHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJlbWFpbCIsImp0aSI6ImZiMDkxNTI0LTc1Y2ItNDYyNi05NDE1LWUwMGRlNDIzNDE5YSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWVpZGVudGlmaWVyIjoidXNlcmlkIiwiZXhwIjoxNTMxNzE4ODE2LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjUwMDAiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjUwMDAifQ.JPohVI4S0FbNBJNVfhvk2iblsEHqm2P3w48JVY3isXY");
        },
        contentType: "application/json;charset=utf-8",
        traditional: true,
        //async: false,
        success: function (data) {
           
        },
        error: function (xhr, ajaxOptions, thrownError) 
        {
            
        }
    });
});