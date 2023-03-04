
var mm = 11;
var bday = 11;
var byear = 1991;
var year = new Date();
var year2 = year.getYear();
var year3 = (year < 2000) ? year2 + 1900 : year2;

thedate = new Date();
mm2 = thedate.getMonth() + 1;
dd2 = thedate.getDate();
yy2 = thedate.getYear();
if (yy2 < 100) yy2 += 1900
yourage = yy2 - byear;
if (mm2 < mm) yourage--;
if ((mm2 == mm) && (dd2 < bday)) yourage--;
TMonth = new Array(
'January','February','March',
'April','May','June','July',
'August','September','October',
'November','December'
);
CurMonth = mm - 1;
bmonth = TMonth[CurMonth];
var age2 = yourage + 1;
var timerID;
var timerRunning = false;
var today = new Date();
var startday = new Date();
var enday = new Date();
var secPerDay = 0;
var minPerDay = 0;
var hourPerDay = 0;
var secsLeft = 0;
var secsRound = 0;
var secsRemain = 0;
var minLeft = 0;
var minRound = 0;
var minRemain = 0;
var timeRemain = 0;
function stopclock() {
if(timerRunning)
clearTimeout(timerID);
timerRunning = false;
}
function startclock() {
stopclock();
showtime();
showtime1();
}

function showtime1() {
startday = new Date(""+bmonth+" "+bday+", "+byear+" 00:00 EDT");
startday.setYear(""+byear+"");
today = new Date();
secsPerDay = 1000 ;
minPerDay = 60 * 1000 ;
hoursPerDay = 60 * 60 * 1000;
PerDay = 24 * 60 * 60 * 1000;
secsLeft = (today.getTime() - startday.getTime()) / minPerDay;
secsRound = Math.round(secsLeft);
secsRemain = secsLeft - secsRound;
secsRemain = (secsRemain < 0) ? secsRemain = 60 - ((secsRound - secsLeft) * 60) : secsRemain = (secsLeft - secsRound) * 60;
secsRemain = Math.round(secsRemain);
minLeft = ((today.getTime() - startday.getTime()) / hoursPerDay);
minRound = Math.round(minLeft);
minRemain = minLeft - minRound;
minRemain = (minRemain < 0) ? minRemain = 60 - ((minRound - minLeft) * 60) : minRemain = ((minLeft - minRound) * 60);
minRemain = Math.round(minRemain - 0.495);
hoursLeft = ((today.getTime() - startday.getTime()) / PerDay);
hoursRound = Math.round(hoursLeft);
hoursRemain = hoursLeft - hoursRound;
hoursRemain = (hoursRemain < 0) ? hoursRemain = 24 - ((hoursRound - hoursLeft) * 24)  : hoursRemain = ((hoursLeft - hoursRound) * 24);
hoursRemain = Math.round(hoursRemain - 0.5);
daysLeft = ((today.getTime() - startday.getTime()) / PerDay);
daysLeft = (daysLeft - 0.5);
daysRound = Math.round(daysLeft);
daysRemain = daysRound;
if (daysRemain >= 3 && daysRemain <= 10) day_rem = " أيام, "
else day_rem = " يوم, "
if (hoursRemain >= 3 && hoursRemain <= 10) hour_rem = " ساعات, "
else hour_rem = " ساعة, "
if (minRemain >= 3 && minRemain <= 10) min_rem = " دقائق, "
else min_rem = " دقيقة, "
if (secsRemain >= 3 && secsRemain <= 10) sec_rem = " ثواني"
else sec_rem = " ثانية"
timeRemain = daysRemain + day_rem + hoursRemain + hour_rem + minRemain + min_rem + secsRemain + sec_rem;
document.up.face.value = timeRemain;
timerID = setTimeout("showtime1()",1000);
timerRunning = true;
}


/*********************** bottom ***************************/
function showtime() {

today = new Date();
bmonthe='August';
bdaye = 20;
year3e= '2008';

enday = new Date(""+bmonthe+", "+bdaye+" "+year3e+" 00:00");
enday.setYear(""+year3e+"");
secsPerDay = 1000 ;
minPerDay = 60 * 1000 ;
hoursPerDay = 60 * 60 * 1000;
PerDay = 24 * 60 * 60 * 1000;
secsLeft = (enday.getTime() - today.getTime()) / minPerDay;
secsRound = Math.round(secsLeft);
secsRemain = secsLeft - secsRound;
secsRemain = (secsRemain < 0) ? secsRemain = 60 - ((secsRound - secsLeft) * 60) : secsRemain = (secsLeft - secsRound) * 60;
secsRemain = Math.round(secsRemain);
minLeft = ((enday.getTime() - today.getTime()) / hoursPerDay);
minRound = Math.round(minLeft);
minRemain = minLeft - minRound;
minRemain = (minRemain < 0) ? minRemain = 60 - ((minRound - minLeft)  * 60) : minRemain = ((minLeft - minRound) * 60);
minRemain = Math.round(minRemain - 0.495);
hoursLeft = ((enday.getTime() - today.getTime()) / PerDay);
hoursRound = Math.round(hoursLeft);
hoursRemain = hoursLeft - hoursRound;
hoursRemain = (hoursRemain < 0) ? hoursRemain = 24 - ((hoursRound - hoursLeft)  * 24) : hoursRemain = ((hoursLeft - hoursRound) * 24);
hoursRemain = Math.round(hoursRemain - 0.5);
daysLeft = ((enday.getTime() - today.getTime()) / PerDay);
daysLeft = (daysLeft - 0.5);
daysRound = Math.round(daysLeft);
daysRemain = daysRound;
if (daysRemain >= 3 && daysRemain <= 10) day_rem = " أيام, "
else day_rem = " يوم, "
if (hoursRemain >= 3 && hoursRemain <= 10) hour_rem = " ساعات, "
else hour_rem = " ساعة, "
if (minRemain >= 3 && minRemain <= 10) min_rem = " دقائق, "
else min_rem = " دقيقة, "
if (secsRemain >= 3 && secsRemain <= 10) sec_rem = " ثواني"
else sec_rem = " ثانية"
timeRemain = daysRemain + day_rem + hoursRemain + hour_rem + minRemain + min_rem + secsRemain + sec_rem;
document.up.face2.value = timeRemain;
timerID = setTimeout("showtime()",1000);
timerRunning = true;
if (daysRemain < 0) year3 = year3 + 1
}



