grammar Calc;

// tokens:
Plus: '+';
Minus: '-';
Multiply: '*';
Divide: '/';
Power: '^';
LeftParen: '('|'（';
RightParen: ')'|'）';
Comma: ','|'，';
LogID: 'log'|'Log';
TrigID: 'sin'|'Sin'|'cos'|'Cos'|'tan'|'Tan';
constPI: 'PI'|'pi'|'π';
constE: 'E'|'e';


Int: '0'|[1-9][0-9]*;
Float: ([1-9][0-9]*|[0-9])'.'[0-9]+;
WhiteSpace: [ \t\r\n]+ -> skip;

// rules:
node: Int | Float | constPI | constE;
log_exp: LogID LeftParen (exp|) Comma (exp|) RightParen // empty parameter may be allowed
    | LogID LeftParen (exp|) RightParen // empty parameter may be allowed
;
trig_exp: TrigID LeftParen (exp|) RightParen;

exp:
    exp Power exp // this alternative will be considered first, corresponding to priority.
    | Minus exp
    |exp (Multiply|Divide) exp 
    | exp (Plus|Minus) exp
    | LeftParen exp RightParen
    | log_exp | trig_exp
    | LeftParen RightParen // empty parentheses may be allowed.
    | node
    ;
