function quad(a,b,c,d,e,f) {
    var x = (f*b - c*e)/(d*b - a*e);
    var y1 = (c - a*x)/b;
	var y2 = (f - d*x)/e;
	var y;
	
	if (b == 0 && e == 0) {
		return "Решения системы нет";
	}
	else if ((d*b - a*e) == 0) {
		return "Решения системы нет";
	}
	else if (b == 0) {
		y = y2;
		return "X = " + x.toFixed(2) + "\nY = " + y.toFixed(2);
	}
	else if (e == 0) {
		y = y1;
		return "X = " + x.toFixed(2) + "\nY = " + y.toFixed(2);
	}
	else  {
		y = y2;
		return "X = " + x.toFixed(2) + "\nY = " + y.toFixed(2);
	}
}

function prog() {
    var a=document.getElementById('a').value;
    var b=document.getElementById('b').value;
    var c=document.getElementById('c').value;
    var d=document.getElementById('d').value;
    var e=document.getElementById('e').value;
    var f=document.getElementById('f').value;
	
    var resultat = quad(a,b,c,d,e,f);

    document.getElementById('result').textContent=resultat;

}