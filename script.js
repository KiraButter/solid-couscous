function quad(a,b,c) {
    var D=b*b-4*a*c;
    var x1;
    var x2;
    
    if (a==0) {
        x1=(-c/b);
        return "Дискриминант D=" + D + "\nКорень уравнения:\nХ1=" + x1.toFixed(1);
    }

    else if (D>0) {
        x1=(-b+Math.sqrt(D))/2*a;
        x2=(-b-Math.sqrt(D))/2*a;
        return "Дискриминант D=" + D + "\nКорни уравнения:\nХ1=" + x1.toFixed(1) + "\nX2=" + x2.toFixed(1);
    }

    else if (D==0) {
        x1=-b/(2*a);
        return "Дискриминант D=" + D + "\nКорень уравнения:\nХ1=" + x1.toFixed(1);
    }

    else if (D<0) {
        let i1=Math.sqrt(-D)/(2*a);
        let i2=-Math.sqrt(-D)/(2*a);
        let x=-b/(2*a);
        
        return "Дискриминант D=" + D + "\nКорни уравнения:\nХ1=" + x + "+" + i1.toFixed(2) + "i" + "\nX2=" + x  + i2.toFixed(2) + "i";
    }

}

function prog() {
    var a=document.getElementById('a').value;
    var b=document.getElementById('b').value;
    var c=document.getElementById('c').value;
    var resultat = quad(a,b,c);

    document.getElementById('result').textContent=resultat;

}