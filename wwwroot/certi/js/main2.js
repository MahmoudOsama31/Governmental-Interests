$(function () {
    
    var CountSelect = $('.cap'),
    
        myCap = ['القاهرة', 'الجيزة'],
        
        Cairo = ['مدينة نصر', 'حلوان', 'القاهرة الجديدة', 'عين شمس', 'المعادي' , 'عين شمس', 'تحرير'],
        
        Giza = ['الواحات البحرية', 'الزمالك', 'سقارة', 'المنيب', 'ساقية مكى' , 'ام المصريين', 'الوراق' ,'اكتوبر'];
        

        
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
$(function () {
    
    var CountSelect = $('.relg'),
    
        myRelg = ['ذكر', 'انثي'],
        
        Man = ['مسلم' , 'مسيحي'],
        
        Woman = ['مسلمة' ,'مسيحية'];
        

        
    // Function Create Option    
    
    function CreateOption(valriable, elementToAppend) {
        
        var i;
        
        for (i = 0; i < valriable.length; i += 1) {
    
            $('<option>', {value: valriable[i], text: valriable[i], id: valriable[i]})
                .appendTo(elementToAppend);
        }
    }
    
    
    // Create Option myCountries
    CreateOption(myRelg, $('.relg'));
    
    // Create Option Africa
    CreateOption(Man, $('.ذكر'));
    
    // Create Option Africa
    CreateOption(Woman, $('.انثي'));
    
    
    // Hide All Select
    $('.religion select').hide();
    
    // Show First Selected
    $('.ذكر').show().css('display', 'inline-block');
    
    
    
    // Show List Option City Whene user Chosse Countries
    
    CountSelect.on('change', function () {
        
        // get Id option 
        var myId = $(this).find(':selected').attr('id');
        console.log($(this).val());
        // Show Select Has class = Id And Hide Siblings
        $('.religion select').filter('.' + myId).fadeIn(400).siblings('select').hide();
        
    });
    
});