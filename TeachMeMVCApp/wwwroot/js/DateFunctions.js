function AddSubstractMonths(date, numMonths) {

    var month = date.getMonth();

    var miliSeconds = new Date(date).setMonth(month + numMonths);

    return new Date(miliSeconds);
}