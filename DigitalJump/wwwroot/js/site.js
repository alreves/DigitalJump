function setInnForSearch(elem) {
    var elem = $(elem);
    var contractDate = moment(elem.data('contract-date')).format('DD.MM.YYYY');
    var searchStr = elem.data('contract-name') + ' от ' + contractDate + ' (' + (elem.data('partner-name')).trim() + ')';

    $('#searchLine').val(searchStr);
    $('#searchLine').data('contract-uid', elem.data('contract-uid'));
    getDocuments();
}

function isTrueChar(e) {
    if (e.which == null) { // IE

        if (e.keyCode < 32 && e.keyCode != 8) return false; // спец. символ, но не backspace
        return true;

    } else if (e.which != 0) { // все кроме IE

        if (e.which < 32 && e.which != 8) return false; // спец. символ, но не backspace
        return true; // остальные

    }

    return false; // спец. символ
}

function subSearchIO(state) {
    if (state == 'on') {

        if ($('#subSearchVariants').hasClass('d-none')) {
            $('#subSearchVariants').removeClass('d-none');
        }

    } else {

        if (!$('#subSearchVariants').hasClass('d-none')) {
            $('#subSearchVariants').addClass('d-none');
        }

    }
}

$('body').click(function () {
    subSearchIO('off');
});


$(window).scroll(function () {
    var scrollTop = $(this).scrollTop();

    if (scrollTop >= 356) {

        $('#smallLogo').addClass('show');
        $('#searchInputGroup').addClass('short');
        $('.main-search-line').addClass('fixed-line');
        $('.body').addClass('fixed-search');

    } else {

        $('#smallLogo').removeClass('show');
        $('#searchInputGroup').removeClass('short');
        $('.main-search-line').removeClass('fixed-line');
        $('.body').removeClass('fixed-search');

    }
});

$('#searchBtn').click(function () {
    getDocuments();
});

$('#searchLine').keyup(function (e) {
    if (e.which == 13 || e.keyCode == 13) {

        subSearchIO('off');
        getDocuments();

    } else if (isTrueChar(e)) {

        $('#searchLine').data('contract-uid', '');
        if ($(this).val().length >= 3) {

            subSearchIO('on');
            getContracts();

        } else {

            $('#subSearchVariants .sub-search-line').remove();
            subSearchIO('off');

        }

    }
});

$('#additionalSearchBtn').click(function (e) {
    e.preventDefault();

    if ($(this).attr('data-status') == 'off') {

        $('#searchLine').prop('disabled', true);
        $('#searchBtn').prop('disabled', true);
        $(this).attr('data-status', 'on');

    } else {

        $('#searchLine').prop('disabled', false);
        $('#searchBtn').prop('disabled', false);
        $(this).attr('data-status', 'off');

    }
});
