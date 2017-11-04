	format	MS COFF
	extrn	___bb_appstub_appstub
	extrn	___bb_audio_audio
	extrn	___bb_bank_bank
	extrn	___bb_bankstream_bankstream
	extrn	___bb_basic_basic
	extrn	___bb_blitz_blitz
	extrn	___bb_bmploader_bmploader
	extrn	___bb_d3d7max2d_d3d7max2d
	extrn	___bb_d3d9max2d_d3d9max2d
	extrn	___bb_data_data
	extrn	___bb_directsoundaudio_directsoundaudio
	extrn	___bb_eventqueue_eventqueue
	extrn	___bb_freeaudioaudio_freeaudioaudio
	extrn	___bb_freejoy_freejoy
	extrn	___bb_freeprocess_freeprocess
	extrn	___bb_freetypefont_freetypefont
	extrn	___bb_glew_glew
	extrn	___bb_gnet_gnet
	extrn	___bb_jpgloader_jpgloader
	extrn	___bb_macos_macos
	extrn	___bb_map_map
	extrn	___bb_maxlua_maxlua
	extrn	___bb_maxutil_maxutil
	extrn	___bb_oggloader_oggloader
	extrn	___bb_openalaudio_openalaudio
	extrn	___bb_pngloader_pngloader
	extrn	___bb_retro_retro
	extrn	___bb_tgaloader_tgaloader
	extrn	___bb_threads_threads
	extrn	___bb_timer_timer
	extrn	___bb_wavloader_wavloader
	extrn	_bbAppArgs
	extrn	_bbDelay
	extrn	_bbEmptyString
	extrn	_bbEnd
	extrn	_bbNullObject
	extrn	_bbOnDebugEnterScope
	extrn	_bbOnDebugEnterStm
	extrn	_bbOnDebugLeaveScope
	extrn	_bbStringClass
	extrn	_bbStringConcat
	extrn	_bbStringFromChar
	extrn	_bbStringFromInt
	extrn	_bbStringToInt
	extrn	_brl_blitz_ArrayBoundsError
	extrn	_brl_blitz_NullObjectError
	extrn	_brl_filesystem_WriteFile
	extrn	_brl_glmax2d_GLMax2DDriver
	extrn	_brl_graphics_Graphics
	extrn	_brl_graphics_SetGraphicsDriver
	extrn	_brl_max2d_Cls
	extrn	_brl_max2d_DrawText
	extrn	_brl_max2d_GrabPixmap
	extrn	_brl_max2d_LoadImageFont
	extrn	_brl_max2d_SetImageFont
	extrn	_brl_max2d_TextHeight
	extrn	_brl_max2d_TextWidth
	extrn	_brl_pixmap_CreatePixmap
	extrn	_brl_standardio_Print
	extrn	_brl_stream_WriteByte
	extrn	_brl_stream_WriteShort
	public	__bb_main
	section	"code" code
__bb_main:
	push	ebp
	mov	ebp,esp
	sub	esp,48
	push	ebx
	push	esi
	push	edi
	cmp	dword [_146],0
	je	_147
	mov	eax,0
	pop	edi
	pop	esi
	pop	ebx
	mov	esp,ebp
	pop	ebp
	ret
_147:
	mov	dword [_146],1
	mov	dword [ebp-4],_bbEmptyString
	mov	dword [ebp-8],0
	mov	dword [ebp-12],_bbNullObject
	mov	dword [ebp-16],_bbNullObject
	mov	dword [ebp-20],0
	mov	dword [ebp-24],0
	mov	dword [ebp-28],0
	mov	dword [ebp-32],_bbNullObject
	mov	dword [ebp-36],_bbNullObject
	mov	dword [ebp-40],0
	mov	dword [ebp-44],0
	mov	dword [ebp-48],0
	mov	eax,ebp
	push	eax
	push	_137
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	call	___bb_blitz_blitz
	call	___bb_appstub_appstub
	call	___bb_audio_audio
	call	___bb_bank_bank
	call	___bb_bankstream_bankstream
	call	___bb_basic_basic
	call	___bb_bmploader_bmploader
	call	___bb_d3d7max2d_d3d7max2d
	call	___bb_d3d9max2d_d3d9max2d
	call	___bb_data_data
	call	___bb_directsoundaudio_directsoundaudio
	call	___bb_eventqueue_eventqueue
	call	___bb_freeaudioaudio_freeaudioaudio
	call	___bb_freetypefont_freetypefont
	call	___bb_gnet_gnet
	call	___bb_jpgloader_jpgloader
	call	___bb_map_map
	call	___bb_maxlua_maxlua
	call	___bb_maxutil_maxutil
	call	___bb_oggloader_oggloader
	call	___bb_openalaudio_openalaudio
	call	___bb_pngloader_pngloader
	call	___bb_retro_retro
	call	___bb_tgaloader_tgaloader
	call	___bb_threads_threads
	call	___bb_timer_timer
	call	___bb_wavloader_wavloader
	call	___bb_freejoy_freejoy
	call	___bb_freeprocess_freeprocess
	call	___bb_glew_glew
	call	___bb_macos_macos
	push	_39
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	2
	call	_brl_glmax2d_GLMax2DDriver
	push	eax
	call	_brl_graphics_SetGraphicsDriver
	add	esp,8
	push	_41
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	0
	push	60
	push	0
	push	480
	push	640
	call	_brl_graphics_Graphics
	add	esp,20
	push	_42
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-4],_1
	push	_44
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-8],12
	push	_46
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [_bbAppArgs]
	cmp	dword [eax+20],1
	jle	_47
	mov	eax,ebp
	push	eax
	push	_51
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_48
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,1
	mov	eax,dword [_bbAppArgs]
	cmp	ebx,dword [eax+20]
	jb	_50
	call	_brl_blitz_ArrayBoundsError
_50:
	mov	eax,dword [_bbAppArgs]
	mov	eax,dword [eax+ebx*4+24]
	mov	dword [ebp-4],eax
	call	dword [_bbOnDebugLeaveScope]
_47:
	push	_52
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [_bbAppArgs]
	cmp	dword [eax+20],2
	jle	_53
	mov	eax,ebp
	push	eax
	push	_57
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_54
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,2
	mov	eax,dword [_bbAppArgs]
	cmp	ebx,dword [eax+20]
	jb	_56
	call	_brl_blitz_ArrayBoundsError
_56:
	mov	eax,dword [_bbAppArgs]
	push	dword [eax+ebx*4+24]
	call	_bbStringToInt
	add	esp,4
	mov	dword [ebp-8],eax
	call	dword [_bbOnDebugLeaveScope]
_53:
	push	_58
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-12],_bbNullObject
	push	_60
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-4]
	cmp	dword [eax+8],1
	jle	_61
	mov	eax,ebp
	push	eax
	push	_69
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_62
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	4
	push	dword [ebp-8]
	push	dword [ebp-4]
	call	_brl_max2d_LoadImageFont
	add	esp,12
	mov	dword [ebp-12],eax
	push	_63
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	cmp	dword [ebp-12],_bbNullObject
	jne	_64
	mov	eax,ebp
	push	eax
	push	_67
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_65
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	_22
	call	_brl_standardio_Print
	add	esp,4
	push	_66
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	call	_bbEnd
	call	dword [_bbOnDebugLeaveScope]
_64:
	push	_68
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-12]
	call	_brl_max2d_SetImageFont
	add	esp,4
	call	dword [_bbOnDebugLeaveScope]
_61:
	push	_70
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-4]
	push	_23
	call	_bbStringConcat
	add	esp,8
	push	eax
	call	_brl_standardio_Print
	add	esp,4
	push	_71
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-8]
	call	_bbStringFromInt
	add	esp,4
	push	eax
	push	_24
	call	_bbStringConcat
	add	esp,8
	push	eax
	call	_brl_standardio_Print
	add	esp,4
	push	_72
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	_25
	push	dword [ebp-4]
	call	_bbStringConcat
	add	esp,8
	push	eax
	call	_brl_filesystem_WriteFile
	add	esp,4
	mov	dword [ebp-16],eax
	push	_74
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-20],0
	mov	dword [ebp-20],0
	jmp	_76
_28:
	mov	eax,ebp
	push	eax
	push	_121
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_77
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	call	_brl_max2d_Cls
	push	_78
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	1073741824
	push	1073741824
	push	dword [ebp-20]
	call	_bbStringFromChar
	add	esp,4
	push	eax
	call	_brl_max2d_DrawText
	add	esp,12
	push	_79
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-20]
	call	_bbStringFromChar
	add	esp,4
	push	eax
	call	_brl_max2d_TextWidth
	add	esp,4
	mov	dword [ebp-24],eax
	push	_81
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-20]
	call	_bbStringFromChar
	add	esp,4
	push	eax
	call	_brl_max2d_TextHeight
	add	esp,4
	mov	dword [ebp-28],eax
	push	_83
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	add	dword [ebp-24],4
	push	_84
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	add	dword [ebp-28],4
	push	_85
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-24]
	push	dword [ebp-16]
	call	_brl_stream_WriteShort
	add	esp,8
	push	_86
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-28]
	push	dword [ebp-16]
	call	_brl_stream_WriteShort
	add	esp,8
	push	_87
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	4
	push	6
	push	dword [ebp-28]
	push	dword [ebp-24]
	call	_brl_pixmap_CreatePixmap
	add	esp,16
	mov	dword [ebp-32],eax
	push	_89
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-28]
	push	dword [ebp-24]
	push	0
	push	0
	call	_brl_max2d_GrabPixmap
	add	esp,16
	mov	dword [ebp-36],eax
	push	_91
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-40],0
	mov	dword [ebp-40],0
	mov	edi,dword [ebp-28]
	jmp	_93
_31:
	mov	eax,ebp
	push	eax
	push	_118
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_95
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-44],0
	mov	dword [ebp-44],0
	mov	esi,dword [ebp-24]
	jmp	_97
_34:
	mov	eax,ebp
	push	eax
	push	_113
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_99
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-36]
	cmp	ebx,_bbNullObject
	jne	_101
	call	_brl_blitz_NullObjectError
_101:
	push	dword [ebp-40]
	push	dword [ebp-44]
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+52]
	add	esp,12
	mov	dword [ebp-48],eax
	push	_103
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-48]
	movzx	eax,byte [eax]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	push	_104
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-48]
	movzx	eax,byte [eax+1]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	push	_105
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-48]
	movzx	eax,byte [eax+2]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	push	_106
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-48]
	movzx	eax,byte [eax]
	mov	eax,eax
	mov	edx,dword [ebp-48]
	movzx	edx,byte [edx+1]
	mov	edx,edx
	add	eax,edx
	mov	edx,dword [ebp-48]
	movzx	edx,byte [edx+2]
	mov	edx,edx
	add	eax,edx
	cmp	eax,0
	jle	_107
	mov	eax,ebp
	push	eax
	push	_109
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_108
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	255
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	call	dword [_bbOnDebugLeaveScope]
	jmp	_110
_107:
	mov	eax,ebp
	push	eax
	push	_112
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_111
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	0
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	call	dword [_bbOnDebugLeaveScope]
_110:
	call	dword [_bbOnDebugLeaveScope]
_32:
	add	dword [ebp-44],1
_97:
	cmp	dword [ebp-44],esi
	jl	_34
_33:
	call	dword [_bbOnDebugLeaveScope]
_29:
	add	dword [ebp-40],1
_93:
	cmp	dword [ebp-40],edi
	jl	_31
_30:
	push	_120
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	_36
	push	dword [ebp-20]
	call	_bbStringFromInt
	add	esp,4
	push	eax
	push	_35
	call	_bbStringConcat
	add	esp,8
	push	eax
	call	_bbStringConcat
	add	esp,8
	push	eax
	call	_brl_standardio_Print
	add	esp,4
	call	dword [_bbOnDebugLeaveScope]
_26:
	add	dword [ebp-20],1
_76:
	cmp	dword [ebp-20],255
	jl	_28
_27:
	push	_128
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-16]
	cmp	ebx,_bbNullObject
	jne	_130
	call	_brl_blitz_NullObjectError
_130:
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+64]
	add	esp,4
	push	_131
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-16]
	cmp	ebx,_bbNullObject
	jne	_133
	call	_brl_blitz_NullObjectError
_133:
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+68]
	add	esp,4
	push	_134
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-16],_bbNullObject
	push	_135
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	1000
	call	_bbDelay
	add	esp,4
	push	_136
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	call	_bbEnd
	mov	ebx,0
	jmp	_37
_37:
	call	dword [_bbOnDebugLeaveScope]
	mov	eax,ebx
	pop	edi
	pop	esi
	pop	ebx
	mov	esp,ebp
	pop	ebp
	ret
	section	"data" data writeable align 8
	align	4
_146:
	dd	0
_138:
	db	"fontBuild",0
_139:
	db	"font_name",0
_140:
	db	"$",0
_141:
	db	"font_size",0
_115:
	db	"i",0
_142:
	db	"tf",0
_143:
	db	":TImageFont",0
_144:
	db	"fo",0
_145:
	db	":TStream",0
	align	4
_137:
	dd	1
	dd	_138
	dd	2
	dd	_139
	dd	_140
	dd	-4
	dd	2
	dd	_141
	dd	_115
	dd	-8
	dd	2
	dd	_142
	dd	_143
	dd	-12
	dd	2
	dd	_144
	dd	_145
	dd	-16
	dd	0
_40:
	db	"C:/Proj/Vivid3D/vividstudio3d/tools/fontBuild/fontBuild.bmx",0
	align	4
_39:
	dd	_40
	dd	4
	dd	1
	align	4
_41:
	dd	_40
	dd	6
	dd	1
	align	4
_42:
	dd	_40
	dd	9
	dd	1
	align	4
_1:
	dd	_bbStringClass
	dd	2147483647
	dd	0
	align	4
_44:
	dd	_40
	dd	10
	dd	1
	align	4
_46:
	dd	_40
	dd	12
	dd	1
	align	4
_51:
	dd	3
	dd	0
	dd	0
	align	4
_48:
	dd	_40
	dd	13
	dd	2
	align	4
_52:
	dd	_40
	dd	16
	dd	1
	align	4
_57:
	dd	3
	dd	0
	dd	0
	align	4
_54:
	dd	_40
	dd	18
	dd	3
	align	4
_58:
	dd	_40
	dd	22
	dd	1
	align	4
_60:
	dd	_40
	dd	24
	dd	1
	align	4
_69:
	dd	3
	dd	0
	dd	0
	align	4
_62:
	dd	_40
	dd	26
	dd	3
	align	4
_63:
	dd	_40
	dd	27
	dd	2
	align	4
_67:
	dd	3
	dd	0
	dd	0
	align	4
_65:
	dd	_40
	dd	29
	dd	3
	align	4
_22:
	dd	_bbStringClass
	dd	2147483647
	dd	20
	dw	102,97,105,108,101,100,32,116,111,32,108,111,97,100,32,102
	dw	111,110,116,46
	align	4
_66:
	dd	_40
	dd	30
	dd	3
	align	4
_68:
	dd	_40
	dd	33
	dd	2
	align	4
_70:
	dd	_40
	dd	38
	dd	1
	align	4
_23:
	dd	_bbStringClass
	dd	2147483647
	dd	13
	dw	80,97,114,115,105,110,103,32,70,111,110,116,58
	align	4
_71:
	dd	_40
	dd	39
	dd	1
	align	4
_24:
	dd	_bbStringClass
	dd	2147483647
	dd	9
	dw	70,111,110,116,83,105,122,101,58
	align	4
_72:
	dd	_40
	dd	41
	dd	1
	align	4
_25:
	dd	_bbStringClass
	dd	2147483647
	dd	3
	dw	46,118,102
	align	4
_74:
	dd	_40
	dd	43
	dd	1
_122:
	db	"c",0
_123:
	db	"cw",0
_124:
	db	"ch",0
_125:
	db	"np",0
_126:
	db	":TPixmap",0
_127:
	db	"cp",0
	align	4
_121:
	dd	3
	dd	0
	dd	2
	dd	_122
	dd	_115
	dd	-20
	dd	2
	dd	_123
	dd	_115
	dd	-24
	dd	2
	dd	_124
	dd	_115
	dd	-28
	dd	2
	dd	_125
	dd	_126
	dd	-32
	dd	2
	dd	_127
	dd	_126
	dd	-36
	dd	0
	align	4
_77:
	dd	_40
	dd	45
	dd	2
	align	4
_78:
	dd	_40
	dd	47
	dd	2
	align	4
_79:
	dd	_40
	dd	49
	dd	2
	align	4
_81:
	dd	_40
	dd	50
	dd	2
	align	4
_83:
	dd	_40
	dd	52
	dd	2
	align	4
_84:
	dd	_40
	dd	53
	dd	2
	align	4
_85:
	dd	_40
	dd	55
	dd	2
	align	4
_86:
	dd	_40
	dd	56
	dd	2
	align	4
_87:
	dd	_40
	dd	58
	dd	2
	align	4
_89:
	dd	_40
	dd	61
	dd	2
	align	4
_91:
	dd	_40
	dd	103
	dd	2
_119:
	db	"y",0
	align	4
_118:
	dd	3
	dd	0
	dd	2
	dd	_119
	dd	_115
	dd	-40
	dd	0
	align	4
_95:
	dd	_40
	dd	104
	dd	2
_114:
	db	"x",0
_116:
	db	"pp",0
_117:
	db	"*b",0
	align	4
_113:
	dd	3
	dd	0
	dd	2
	dd	_114
	dd	_115
	dd	-44
	dd	2
	dd	_116
	dd	_117
	dd	-48
	dd	0
	align	4
_99:
	dd	_40
	dd	106
	dd	3
	align	4
_103:
	dd	_40
	dd	108
	dd	3
	align	4
_104:
	dd	_40
	dd	109
	dd	3
	align	4
_105:
	dd	_40
	dd	110
	dd	3
	align	4
_106:
	dd	_40
	dd	112
	dd	3
	align	4
_109:
	dd	3
	dd	0
	dd	0
	align	4
_108:
	dd	_40
	dd	114
	dd	4
	align	4
_112:
	dd	3
	dd	0
	dd	0
	align	4
_111:
	dd	_40
	dd	118
	dd	4
	align	4
_120:
	dd	_40
	dd	125
	dd	2
	align	4
_36:
	dd	_bbStringClass
	dd	2147483647
	dd	4
	dw	47,50,53,53
	align	4
_35:
	dd	_bbStringClass
	dd	2147483647
	dd	13
	dw	80,97,114,115,101,100,32,73,110,100,101,120,58
	align	4
_128:
	dd	_40
	dd	130
	dd	1
	align	4
_131:
	dd	_40
	dd	132
	dd	1
	align	4
_134:
	dd	_40
	dd	134
	dd	1
	align	4
_135:
	dd	_40
	dd	136
	dd	1
	align	4
_136:
	dd	_40
	dd	138
	dd	1
