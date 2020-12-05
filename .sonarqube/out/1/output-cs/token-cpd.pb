¦
bC:\Users\claud\source\repos\DataGenerator\DataGenerator.Api\Controllers\DataGeneratorController.cs
	namespace

 	
DataGenerator


 
.

 
Api

 
.

 
Controllers

 '
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class #
DataGeneratorController (
:) *
ControllerBase+ 9
{ 
private 
readonly "
IDataGeneratorServices /"
_dataGeneratorServices0 F
;F G
public #
DataGeneratorController &
(& '"
IDataGeneratorServices' =!
dataGeneratorServices> S
)S T
{ 	"
_dataGeneratorServices "
=# $!
dataGeneratorServices% :
;: ;
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
public 
async 
Task 
< 
IEnumerable %
<% &
PersonModel& 1
>1 2
>2 3!
GetAllPersonListAsync4 I
(I J
[J K
	FromQueryK T
]T U
uintV Z
quantity[ c
=d e
$numf g
)g h
{ 	
var 
response 
= 
await  "
_dataGeneratorServices! 7
.7 8#
GeneratePersonListAsync8 O
(O P
quantityP X
)X Y
;Y Z
return 
response 
; 
} 	
[   	
HttpGet  	 
(   
$str   
)   
]   
public!! 
async!! 
Task!! 
<!! 
PersonModel!! %
>!!% &
GetPersonByIdAsync!!' 9
(!!9 :
[!!: ;
	FromQuery!!; D
]!!D E
uint!!F J
id!!K M
)!!M N
{"" 	
var## 
response## 
=## 
await##  "
_dataGeneratorServices##! 7
.##7 8#
GeneratePersonListAsync##8 O
(##O P
$num##P Q
)##Q R
;##R S
return%% 
response%% 
.%% 
FirstOrDefault%% *
(%%* +
)%%+ ,
;%%, -
}&& 	
[++ 	
HttpGet++	 
(++ 
$str++ 
)++ 
]++ 
public,, 
async,, 
Task,, 
<,, 
IEnumerable,, %
<,,% &
ProductModel,,& 2
>,,2 3
>,,3 4"
GetAllProductListAsync,,5 K
(,,K L
[,,L M
	FromQuery,,M V
],,V W
uint,,X \
quantity,,] e
=,,f g
$num,,h i
),,i j
{-- 	
var.. 
response.. 
=.. 
await..  "
_dataGeneratorServices..! 7
...7 8$
GenerateProductListAsync..8 P
(..P Q
quantity..Q Y
)..Y Z
;..Z [
return00 
response00 
;00 
}11 	
[33 	
HttpGet33	 
(33 
$str33 
)33 
]33 
public44 
async44 
Task44 
<44 
ProductModel44 &
>44& '
GetProductByIdAsync44( ;
(44; <
[44< =
	FromQuery44= F
]44F G
uint44H L
id44M O
)44O P
{55 	
var66 
response66 
=66 
await66  "
_dataGeneratorServices66! 7
.667 8$
GenerateProductListAsync668 P
(66P Q
$num66Q R
)66R S
;66S T
return88 
response88 
.88 
FirstOrDefault88 *
(88* +
)88+ ,
;88, -
}99 	
}== 
}>> Á

FC:\Users\claud\source\repos\DataGenerator\DataGenerator.Api\Program.cs
	namespace 	
DataGenerator
 
. 
Api 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{		 	
CreateHostBuilder

 
(

 
args

 "
)

" #
.

# $
Build

$ )
(

) *
)

* +
.

+ ,
Run

, /
(

/ 0
)

0 1
;

1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} Ã
FC:\Users\claud\source\repos\DataGenerator\DataGenerator.Api\Startup.cs
	namespace 	
DataGenerator
 
. 
Api 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddControllers #
(# $
)$ %
;% &
services 
. 
AddTransient !
<! ""
IDataGeneratorServices" 8
,8 9!
DataGeneratorServices: O
>O P
(P Q
)Q R
;R S
services 
. 
AddTransient !
<! "

IGenerator" ,
,, -
	Generator. 7
>7 8
(8 9
)9 :
;: ;
services 
. 
AddSwaggerGen "
(" #
c# $
=>% '
{   
c!! 
.!! 

SwaggerDoc!! 
(!! 
$str!! !
,!!! "
new!!# &
OpenApiInfo!!' 2
{!!3 4
Title!!5 :
=!!; <
$str!!= Q
,!!Q R
Version!!S Z
=!![ \
$str!!] a
}!!b c
)!!c d
;!!d e
}"" 
)"" 
;"" 
}$$ 	
public&& 
void&& 
	Configure&& 
(&& 
IApplicationBuilder&& 1
app&&2 5
,&&5 6
IWebHostEnvironment&&7 J
env&&K N
)&&N O
{'' 	
if(( 
((( 
env(( 
.(( 
IsDevelopment(( !
(((! "
)((" #
)((# $
{)) 
app** 
.** %
UseDeveloperExceptionPage** -
(**- .
)**. /
;**/ 0
}++ 
app-- 
.-- 
UseHttpsRedirection-- #
(--# $
)--$ %
;--% &
app// 
.// 

UseRouting// 
(// 
)// 
;// 
app11 
.11 
UseAuthorization11  
(11  !
)11! "
;11" #
app33 
.33 
UseEndpoints33 
(33 
	endpoints33 &
=>33' )
{44 
	endpoints55 
.55 
MapControllers55 (
(55( )
)55) *
;55* +
}66 
)66 
;66 
app88 
.88 

UseSwagger88 
(88 
)88 
;88 
app99 
.99 
UseSwaggerUI99 
(99 
c99 
=>99 !
{:: 
c;; 
.;; 
SwaggerEndpoint;; !
(;;! "
$str;;" <
,;;< =
$str;;> R
);;R S
;;;S T
}<< 
)<< 
;<< 
}== 	
}>> 
}?? 