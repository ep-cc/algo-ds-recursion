function value(estr) {
  const pi = estr.indexOf('+');
  if (pi > -1) {
    const first = value(estr.slice(0,pi));
    const second = value(estr.slice(pi + 1));
    return first + second;
  } else {
    const mi = estr.indexOf('*');
    if (mi > -1) {
      const first = value(estr.slice(0,mi));
      const second = value(estr.slice(mi + 1));
      return first * second;
    } else {
      return parseInt(estr);
    }
  }
}

console.log(value('12'));               // 12
console.log(value('1+2'));              // 3 
console.log(value('1+2*3'));            // 7
console.log(value('23+2*7+1+44+5*5'));  // 107 
