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
	sub	esp,88
	push	ebx
	push	esi
	push	edi
	cmp	dword [_212],0
	je	_213
	mov	eax,0
	pop	edi
	pop	esi
	pop	ebx
	mov	esp,ebp
	pop	ebp
	ret
_213:
	mov	dword [_212],1
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
	mov	dword [ebp-52],0
	mov	dword [ebp-60],0
	mov	dword [ebp-64],0
	mov	dword [ebp-68],0
	mov	dword [ebp-56],0
	mov	dword [ebp-72],0
	mov	dword [ebp-76],0
	mov	dword [ebp-80],0
	mov	eax,ebp
	push	eax
	push	_203
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
	push	_51
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	2
	call	_brl_glmax2d_GLMax2DDriver
	push	eax
	call	_brl_graphics_SetGraphicsDriver
	add	esp,8
	push	_53
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	0
	push	60
	push	0
	push	480
	push	640
	call	_brl_graphics_Graphics
	add	esp,20
	push	_54
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-4],_1
	push	_56
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-8],12
	push	_58
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [_bbAppArgs]
	cmp	dword [eax+20],1
	jle	_59
	mov	eax,ebp
	push	eax
	push	_63
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_60
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,1
	mov	eax,dword [_bbAppArgs]
	cmp	ebx,dword [eax+20]
	jb	_62
	call	_brl_blitz_ArrayBoundsError
_62:
	mov	eax,dword [_bbAppArgs]
	mov	eax,dword [eax+ebx*4+24]
	mov	dword [ebp-4],eax
	call	dword [_bbOnDebugLeaveScope]
_59:
	push	_64
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [_bbAppArgs]
	cmp	dword [eax+20],2
	jle	_65
	mov	eax,ebp
	push	eax
	push	_69
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_66
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,2
	mov	eax,dword [_bbAppArgs]
	cmp	ebx,dword [eax+20]
	jb	_68
	call	_brl_blitz_ArrayBoundsError
_68:
	mov	eax,dword [_bbAppArgs]
	push	dword [eax+ebx*4+24]
	call	_bbStringToInt
	add	esp,4
	mov	dword [ebp-8],eax
	call	dword [_bbOnDebugLeaveScope]
_65:
	push	_70
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-12],_bbNullObject
	push	_72
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-4]
	cmp	dword [eax+8],1
	jle	_73
	mov	eax,ebp
	push	eax
	push	_81
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_74
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	4
	push	dword [ebp-8]
	push	dword [ebp-4]
	call	_brl_max2d_LoadImageFont
	add	esp,12
	mov	dword [ebp-12],eax
	push	_75
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	cmp	dword [ebp-12],_bbNullObject
	jne	_76
	mov	eax,ebp
	push	eax
	push	_79
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_77
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	_22
	call	_brl_standardio_Print
	add	esp,4
	push	_78
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	call	_bbEnd
	call	dword [_bbOnDebugLeaveScope]
_76:
	push	_80
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-12]
	call	_brl_max2d_SetImageFont
	add	esp,4
	call	dword [_bbOnDebugLeaveScope]
_73:
	push	_82
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-4]
	push	_23
	call	_bbStringConcat
	add	esp,8
	push	eax
	call	_brl_standardio_Print
	add	esp,4
	push	_83
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
	push	_84
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
	push	_86
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-20],0
	mov	dword [ebp-20],0
	jmp	_88
_28:
	mov	eax,ebp
	push	eax
	push	_187
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_89
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	call	_brl_max2d_Cls
	push	_90
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
	push	_91
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-20]
	call	_bbStringFromChar
	add	esp,4
	push	eax
	call	_brl_max2d_TextWidth
	add	esp,4
	mov	dword [ebp-24],eax
	push	_93
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-20]
	call	_bbStringFromChar
	add	esp,4
	push	eax
	call	_brl_max2d_TextHeight
	add	esp,4
	mov	dword [ebp-28],eax
	push	_95
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	add	dword [ebp-24],4
	push	_96
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	add	dword [ebp-28],4
	push	_97
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-24]
	push	dword [ebp-16]
	call	_brl_stream_WriteShort
	add	esp,8
	push	_98
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-28]
	push	dword [ebp-16]
	call	_brl_stream_WriteShort
	add	esp,8
	push	_99
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	4
	push	6
	push	dword [ebp-28]
	push	dword [ebp-24]
	call	_brl_pixmap_CreatePixmap
	add	esp,16
	mov	dword [ebp-32],eax
	push	_101
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-28]
	push	dword [ebp-24]
	push	0
	push	0
	call	_brl_max2d_GrabPixmap
	add	esp,16
	mov	dword [ebp-36],eax
	push	_103
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-40],0
	mov	dword [ebp-40],0
	mov	eax,dword [ebp-28]
	mov	dword [ebp-88],eax
	jmp	_105
_31:
	mov	eax,ebp
	push	eax
	push	_159
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_107
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-44],0
	mov	dword [ebp-44],0
	mov	eax,dword [ebp-24]
	mov	dword [ebp-84],eax
	jmp	_109
_34:
	mov	eax,ebp
	push	eax
	push	_154
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_111
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-48],0
	push	_113
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-52],0
	push	_115
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-60],0
	mov	eax,dword [ebp-40]
	sub	eax,2
	mov	dword [ebp-60],eax
	mov	eax,dword [ebp-40]
	add	eax,2
	mov	edi,eax
	jmp	_117
_37:
	mov	eax,ebp
	push	eax
	push	_143
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_119
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-64],0
	mov	eax,dword [ebp-44]
	sub	eax,2
	mov	dword [ebp-64],eax
	mov	eax,dword [ebp-44]
	add	eax,2
	mov	esi,eax
	jmp	_121
_40:
	mov	eax,ebp
	push	eax
	push	_140
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_123
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-64]
	cmp	eax,0
	setge	al
	movzx	eax,al
	cmp	eax,0
	je	_124
	mov	eax,dword [ebp-64]
	cmp	eax,dword [ebp-24]
	setl	al
	movzx	eax,al
_124:
	cmp	eax,0
	je	_126
	mov	eax,dword [ebp-60]
	cmp	eax,0
	setge	al
	movzx	eax,al
_126:
	cmp	eax,0
	je	_128
	mov	eax,dword [ebp-60]
	cmp	eax,dword [ebp-28]
	setl	al
	movzx	eax,al
_128:
	cmp	eax,0
	je	_130
	mov	eax,ebp
	push	eax
	push	_137
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_131
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-36]
	cmp	ebx,_bbNullObject
	jne	_133
	call	_brl_blitz_NullObjectError
_133:
	push	dword [ebp-60]
	push	dword [ebp-64]
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+52]
	add	esp,12
	mov	dword [ebp-68],eax
	push	_135
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-68]
	movzx	eax,byte [eax]
	mov	eax,eax
	add	dword [ebp-48],eax
	push	_136
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	add	dword [ebp-52],1
	call	dword [_bbOnDebugLeaveScope]
_130:
	call	dword [_bbOnDebugLeaveScope]
_38:
	add	dword [ebp-64],1
_121:
	cmp	dword [ebp-64],esi
	jle	_40
_39:
	call	dword [_bbOnDebugLeaveScope]
_35:
	add	dword [ebp-60],1
_117:
	cmp	dword [ebp-60],edi
	jle	_37
_36:
	push	_145
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-48]
	cdq
	idiv	dword [ebp-52]
	mov	dword [ebp-48],eax
	push	_146
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-32]
	cmp	ebx,_bbNullObject
	jne	_148
	call	_brl_blitz_NullObjectError
_148:
	push	dword [ebp-40]
	push	dword [ebp-44]
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+52]
	add	esp,12
	mov	dword [ebp-56],eax
	push	_150
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	edx,dword [ebp-56]
	mov	eax,dword [ebp-48]
	and	eax,0xff
	mov	eax,eax
	mov	byte [edx],al
	push	_151
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	edx,dword [ebp-56]
	mov	eax,dword [ebp-48]
	and	eax,0xff
	mov	eax,eax
	mov	byte [edx+1],al
	push	_152
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	edx,dword [ebp-56]
	mov	eax,dword [ebp-48]
	and	eax,0xff
	mov	eax,eax
	mov	byte [edx+2],al
	push	_153
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	edx,dword [ebp-56]
	mov	eax,dword [ebp-48]
	and	eax,0xff
	mov	eax,eax
	mov	byte [edx+3],al
	call	dword [_bbOnDebugLeaveScope]
_32:
	add	dword [ebp-44],1
_109:
	mov	eax,dword [ebp-84]
	cmp	dword [ebp-44],eax
	jl	_34
_33:
	call	dword [_bbOnDebugLeaveScope]
_29:
	add	dword [ebp-40],1
_105:
	mov	eax,dword [ebp-88]
	cmp	dword [ebp-40],eax
	jl	_31
_30:
	push	_161
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-72],0
	mov	dword [ebp-72],0
	mov	edi,dword [ebp-28]
	jmp	_163
_43:
	mov	eax,ebp
	push	eax
	push	_185
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_165
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-76],0
	mov	dword [ebp-76],0
	mov	esi,dword [ebp-24]
	jmp	_167
_46:
	mov	eax,ebp
	push	eax
	push	_183
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_169
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-32]
	cmp	ebx,_bbNullObject
	jne	_171
	call	_brl_blitz_NullObjectError
_171:
	push	dword [ebp-72]
	push	dword [ebp-76]
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+52]
	add	esp,12
	mov	dword [ebp-80],eax
	push	_173
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-80]
	movzx	eax,byte [eax]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	push	_174
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-80]
	movzx	eax,byte [eax+1]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	push	_175
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-80]
	movzx	eax,byte [eax+2]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	push	_176
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-80]
	movzx	eax,byte [eax]
	mov	eax,eax
	mov	edx,dword [ebp-80]
	movzx	edx,byte [edx+1]
	mov	edx,edx
	add	eax,edx
	mov	edx,dword [ebp-80]
	movzx	edx,byte [edx+2]
	mov	edx,edx
	add	eax,edx
	cmp	eax,0
	jle	_177
	mov	eax,ebp
	push	eax
	push	_179
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_178
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-80]
	movzx	eax,byte [eax+3]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	call	dword [_bbOnDebugLeaveScope]
	jmp	_180
_177:
	mov	eax,ebp
	push	eax
	push	_182
	call	dword [_bbOnDebugEnterScope]
	add	esp,8
	push	_181
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	eax,dword [ebp-80]
	movzx	eax,byte [eax+3]
	mov	eax,eax
	push	eax
	push	dword [ebp-16]
	call	_brl_stream_WriteByte
	add	esp,8
	call	dword [_bbOnDebugLeaveScope]
_180:
	call	dword [_bbOnDebugLeaveScope]
_44:
	add	dword [ebp-76],1
_167:
	cmp	dword [ebp-76],esi
	jl	_46
_45:
	call	dword [_bbOnDebugLeaveScope]
_41:
	add	dword [ebp-72],1
_163:
	cmp	dword [ebp-72],edi
	jl	_43
_42:
	push	_186
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	_48
	push	dword [ebp-20]
	call	_bbStringFromInt
	add	esp,4
	push	eax
	push	_47
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
_88:
	cmp	dword [ebp-20],255
	jl	_28
_27:
	push	_194
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-16]
	cmp	ebx,_bbNullObject
	jne	_196
	call	_brl_blitz_NullObjectError
_196:
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+64]
	add	esp,4
	push	_197
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,dword [ebp-16]
	cmp	ebx,_bbNullObject
	jne	_199
	call	_brl_blitz_NullObjectError
_199:
	push	ebx
	mov	eax,dword [ebx]
	call	dword [eax+68]
	add	esp,4
	push	_200
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	dword [ebp-16],_bbNullObject
	push	_201
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	1000
	call	_bbDelay
	add	esp,4
	push	_202
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	call	_bbEnd
	mov	ebx,0
	jmp	_49
_49:
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
_212:
	dd	0
_204:
	db	"fontBuild",0
_205:
	db	"font_name",0
_206:
	db	"$",0
_207:
	db	"font_size",0
_142:
	db	"i",0
_208:
	db	"tf",0
_209:
	db	":TImageFont",0
_210:
	db	"fo",0
_211:
	db	":TStream",0
	align	4
_203:
	dd	1
	dd	_204
	dd	2
	dd	_205
	dd	_206
	dd	-4
	dd	2
	dd	_207
	dd	_142
	dd	-8
	dd	2
	dd	_208
	dd	_209
	dd	-12
	dd	2
	dd	_210
	dd	_211
	dd	-16
	dd	0
_52:
	db	"C:/Proj/Vivid3D/vividstudio3d/tools/fontBuild/fontBuild.bmx",0
	align	4
_51:
	dd	_52
	dd	4
	dd	1
	align	4
_53:
	dd	_52
	dd	6
	dd	1
	align	4
_54:
	dd	_52
	dd	9
	dd	1
	align	4
_1:
	dd	_bbStringClass
	dd	2147483647
	dd	0
	align	4
_56:
	dd	_52
	dd	10
	dd	1
	align	4
_58:
	dd	_52
	dd	12
	dd	1
	align	4
_63:
	dd	3
	dd	0
	dd	0
	align	4
_60:
	dd	_52
	dd	13
	dd	2
	align	4
_64:
	dd	_52
	dd	16
	dd	1
	align	4
_69:
	dd	3
	dd	0
	dd	0
	align	4
_66:
	dd	_52
	dd	18
	dd	3
	align	4
_70:
	dd	_52
	dd	22
	dd	1
	align	4
_72:
	dd	_52
	dd	24
	dd	1
	align	4
_81:
	dd	3
	dd	0
	dd	0
	align	4
_74:
	dd	_52
	dd	26
	dd	3
	align	4
_75:
	dd	_52
	dd	27
	dd	2
	align	4
_79:
	dd	3
	dd	0
	dd	0
	align	4
_77:
	dd	_52
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
_78:
	dd	_52
	dd	30
	dd	3
	align	4
_80:
	dd	_52
	dd	33
	dd	2
	align	4
_82:
	dd	_52
	dd	38
	dd	1
	align	4
_23:
	dd	_bbStringClass
	dd	2147483647
	dd	13
	dw	80,97,114,115,105,110,103,32,70,111,110,116,58
	align	4
_83:
	dd	_52
	dd	39
	dd	1
	align	4
_24:
	dd	_bbStringClass
	dd	2147483647
	dd	9
	dw	70,111,110,116,83,105,122,101,58
	align	4
_84:
	dd	_52
	dd	41
	dd	1
	align	4
_25:
	dd	_bbStringClass
	dd	2147483647
	dd	3
	dw	46,118,102
	align	4
_86:
	dd	_52
	dd	43
	dd	1
_188:
	db	"c",0
_189:
	db	"cw",0
_190:
	db	"ch",0
_191:
	db	"np",0
_192:
	db	":TPixmap",0
_193:
	db	"cp",0
	align	4
_187:
	dd	3
	dd	0
	dd	2
	dd	_188
	dd	_142
	dd	-20
	dd	2
	dd	_189
	dd	_142
	dd	-24
	dd	2
	dd	_190
	dd	_142
	dd	-28
	dd	2
	dd	_191
	dd	_192
	dd	-32
	dd	2
	dd	_193
	dd	_192
	dd	-36
	dd	0
	align	4
_89:
	dd	_52
	dd	45
	dd	2
	align	4
_90:
	dd	_52
	dd	47
	dd	2
	align	4
_91:
	dd	_52
	dd	49
	dd	2
	align	4
_93:
	dd	_52
	dd	50
	dd	2
	align	4
_95:
	dd	_52
	dd	52
	dd	2
	align	4
_96:
	dd	_52
	dd	53
	dd	2
	align	4
_97:
	dd	_52
	dd	55
	dd	2
	align	4
_98:
	dd	_52
	dd	56
	dd	2
	align	4
_99:
	dd	_52
	dd	58
	dd	2
	align	4
_101:
	dd	_52
	dd	60
	dd	2
	align	4
_103:
	dd	_52
	dd	61
	dd	2
_160:
	db	"y",0
	align	4
_159:
	dd	3
	dd	0
	dd	2
	dd	_160
	dd	_142
	dd	-40
	dd	0
	align	4
_107:
	dd	_52
	dd	62
	dd	2
_155:
	db	"x",0
_156:
	db	"col",0
_157:
	db	"ic",0
_158:
	db	"p2",0
_139:
	db	"*b",0
	align	4
_154:
	dd	3
	dd	0
	dd	2
	dd	_155
	dd	_142
	dd	-44
	dd	2
	dd	_156
	dd	_142
	dd	-48
	dd	2
	dd	_157
	dd	_142
	dd	-52
	dd	2
	dd	_158
	dd	_139
	dd	-56
	dd	0
	align	4
_111:
	dd	_52
	dd	64
	dd	3
	align	4
_113:
	dd	_52
	dd	65
	dd	3
	align	4
_115:
	dd	_52
	dd	67
	dd	3
_144:
	db	"sy",0
	align	4
_143:
	dd	3
	dd	0
	dd	2
	dd	_144
	dd	_142
	dd	-60
	dd	0
	align	4
_119:
	dd	_52
	dd	68
	dd	3
_141:
	db	"sx",0
	align	4
_140:
	dd	3
	dd	0
	dd	2
	dd	_141
	dd	_142
	dd	-64
	dd	0
	align	4
_123:
	dd	_52
	dd	70
	dd	4
_138:
	db	"p1",0
	align	4
_137:
	dd	3
	dd	0
	dd	2
	dd	_138
	dd	_139
	dd	-68
	dd	0
	align	4
_131:
	dd	_52
	dd	72
	dd	5
	align	4
_135:
	dd	_52
	dd	73
	dd	5
	align	4
_136:
	dd	_52
	dd	74
	dd	5
	align	4
_145:
	dd	_52
	dd	82
	dd	3
	align	4
_146:
	dd	_52
	dd	84
	dd	3
	align	4
_150:
	dd	_52
	dd	86
	dd	3
	align	4
_151:
	dd	_52
	dd	87
	dd	3
	align	4
_152:
	dd	_52
	dd	88
	dd	3
	align	4
_153:
	dd	_52
	dd	90
	dd	3
	align	4
_161:
	dd	_52
	dd	97
	dd	2
	align	4
_185:
	dd	3
	dd	0
	dd	2
	dd	_160
	dd	_142
	dd	-72
	dd	0
	align	4
_165:
	dd	_52
	dd	98
	dd	2
_184:
	db	"pp",0
	align	4
_183:
	dd	3
	dd	0
	dd	2
	dd	_155
	dd	_142
	dd	-76
	dd	2
	dd	_184
	dd	_139
	dd	-80
	dd	0
	align	4
_169:
	dd	_52
	dd	100
	dd	3
	align	4
_173:
	dd	_52
	dd	102
	dd	3
	align	4
_174:
	dd	_52
	dd	103
	dd	3
	align	4
_175:
	dd	_52
	dd	104
	dd	3
	align	4
_176:
	dd	_52
	dd	106
	dd	3
	align	4
_179:
	dd	3
	dd	0
	dd	0
	align	4
_178:
	dd	_52
	dd	108
	dd	4
	align	4
_182:
	dd	3
	dd	0
	dd	0
	align	4
_181:
	dd	_52
	dd	112
	dd	4
	align	4
_186:
	dd	_52
	dd	119
	dd	2
	align	4
_48:
	dd	_bbStringClass
	dd	2147483647
	dd	4
	dw	47,50,53,53
	align	4
_47:
	dd	_bbStringClass
	dd	2147483647
	dd	13
	dw	80,97,114,115,101,100,32,73,110,100,101,120,58
	align	4
_194:
	dd	_52
	dd	124
	dd	1
	align	4
_197:
	dd	_52
	dd	126
	dd	1
	align	4
_200:
	dd	_52
	dd	128
	dd	1
	align	4
_201:
	dd	_52
	dd	130
	dd	1
	align	4
_202:
	dd	_52
	dd	132
	dd	1
