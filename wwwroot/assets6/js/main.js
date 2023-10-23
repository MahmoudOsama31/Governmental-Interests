$(function () {
    
    var CountSelect = $('.cap'),
    
        myCap = ['القاهرة', 'الجيزة'],
        
        Cairo = ['قسم شرطة مدينة نصر اول','قسم شرطة عابدين','قسم شرطة حلوان','قسم شرطة باب الشعرية','قسم شرطة الموسكى','قسم شرطة الظاهر','قسم شرطة السيدة زينب','قسم شرطة الشرابية','قسم شرطة النزهة ','قسم شرطة المرج','قسم شرطة القاهرة الجديدة اول (التجمع الخامس)','قسم شرطة التبين','قسم شرطة الدرب الاحمر','قسم شرطة مصر القديمة', 'قسم شرطة المعادي', 'قسم شرطة الساحل', 'قسم شرطة الزيتون', 'قسم شرطة الخليفة' , 'قسم شرطة البساتين', 'قسم شرطة ١٥ مايو'],
        
        Giza = ['قسم شرطة إمبابة', 'قسم شرطة الوراق', 'قسم شرطة العياط', 'قسم شرطة العمرانية', 'قسم شرطة العجوزة' , 'قسم شرطة الشيخ زايد', 'قسم شرطة الدقى' ,'قسم شرطة الجيزة'];


        
    // Function Create Option    
    
    function CreateOption(valriable, elementToAppend) {
        
        var i;
        
        for (i = 0; i < valriable.length; i += 1) {
    
            $('<option>', {value: valriable[i], text: valriable[i], id: valriable[i]})
                .appendTo(elementToAppend);
        }
    }
    
    
    // Create Option myCountries
    CreateOption(myCap, $('.cap'));
    
    // Create Option Africa
    CreateOption(Cairo, $('.القاهرة'));
    
    // Create Option Africa
    CreateOption(Giza, $('.الجيزة'));
    
    
    // Hide All Select
    $('.city select').hide();
    
    // Show First Selected
    $('.القاهرة').show().css('display', 'inline-block');
    
    
    
    // Show List Option City Whene user Chosse Countries
    
    CountSelect.on('change', function () {
        
        // get Id option 
        var myId = $(this).find(':selected').attr('id');
        console.log($(this).val());
        // Show Select Has class = Id And Hide Siblings
        $('.city select').filter('.' + myId).fadeIn(400).siblings('select').hide();
        
    });
    
});