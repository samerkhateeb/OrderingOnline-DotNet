/// <reference name="MicrosoftAjax.js"/>
    Sys.Application.add_load(page_load);
    Sys.Application.add_unload(page_unload);
    
    function page_load()
    {
        if($get('ctl00$MoveToServer')!=null)
        $addHandler($get('ctl00$MoveToServer'), 'onclick', onMoveToServerClick); 
    }
    
    function page_unload()
    { 
        
        $addHandler($get('ctl00$MoveToServer'), 'onclick', onMoveToServerClick); 
    }
    
    function onMoveToServerClick(id)
    {
        __doPostBack ('ctl00$MoveToServer',id); 
    }
    
    
    function RequestDataCollection (Did)
    {
        onMoveToServerClick (Did);
    }
    
    function getScrollPos()
    {
        return document.documentElement.scrolly.value;
    }
    
    
    