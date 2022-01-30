$(function () {

    function WireUpDatePicker() {

        const addMonths = 2;
        const currDate = new Date();

        $('.datepicker').datepicker(
            {
                dateFormat: 'yy-mm-dd',
                minDate: currDate,
                maxDate: AddSubstractMonths(currDate, addMonths)
            }
        );
    }

    WireUpDatePicker();

});