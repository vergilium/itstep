.686
.MODEL FLAT, C
.STACK
.DATA
.CODE
plus PROC a:DWORD, b:DWORD 
    mov eax, b;
    add eax, a;
    ret
plus ENDP
demo PROC 
    mov eax, 100;
    ret
demo ENDP
END
