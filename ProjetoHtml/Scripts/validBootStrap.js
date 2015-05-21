var validationClass = {
    validateForm: function ($el, $msg) {
        $($el).closest("div")
              .removeClass("has-error");

        $($el).closest("div").find("small").remove();

        var isValid = true;

        if ($($el).val() == "") {
            $($el).closest("div")
            .addClass("has-error");
            isValid = false;
            $($el).closest("div").append("<small class='error-msg'>" + $msg + "</small>");
        }

        return isValid;
    }

}

