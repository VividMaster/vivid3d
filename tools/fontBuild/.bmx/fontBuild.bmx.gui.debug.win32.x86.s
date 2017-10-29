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
	extrn	_bbEmptyString
	extrn	_bbOnDebugEnterScope
	extrn	_bbOnDebugEnterStm
	extrn	_bbOnDebugLeaveScope
	extrn	_bbStringClass
	extrn	_bbStringConcat
	extrn	_brl_blitz_ArrayBoundsError
	extrn	_brl_standardio_Print
	public	__bb_main
	section	"code" code
__bb_main:
	push	ebp
	mov	ebp,esp
	sub	esp,4
	push	ebx
	cmp	dword [_35],0
	je	_36
	mov	eax,0
	pop	ebx
	mov	esp,ebp
	pop	ebp
	ret
_36:
	mov	dword [_35],1
	mov	dword [ebp-4],_bbEmptyString
	push	ebp
	push	_31
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
	push	_25
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	mov	ebx,1
	mov	eax,dword [_bbAppArgs]
	cmp	ebx,dword [eax+20]
	jb	_28
	call	_brl_blitz_ArrayBoundsError
_28:
	mov	eax,dword [_bbAppArgs]
	mov	eax,dword [eax+ebx*4+24]
	mov	dword [ebp-4],eax
	push	_30
	call	dword [_bbOnDebugEnterStm]
	add	esp,4
	push	dword [ebp-4]
	push	_22
	call	_bbStringConcat
	add	esp,8
	push	eax
	call	_brl_standardio_Print
	add	esp,4
	mov	ebx,0
	jmp	_23
_23:
	call	dword [_bbOnDebugLeaveScope]
	mov	eax,ebx
	pop	ebx
	mov	esp,ebp
	pop	ebp
	ret
	section	"data" data writeable align 8
	align	4
_35:
	dd	0
_32:
	db	"fontBuild",0
_33:
	db	"font_name",0
_34:
	db	"$",0
	align	4
_31:
	dd	1
	dd	_32
	dd	2
	dd	_33
	dd	_34
	dd	-4
	dd	0
_26:
	db	"C:/Dev/Proj/Vivid3D/vividstudio3d/tools/fontBuild/fontBuild.bmx",0
	align	4
_25:
	dd	_26
	dd	4
	dd	1
	align	4
_30:
	dd	_26
	dd	6
	dd	1
	align	4
_22:
	dd	_bbStringClass
	dd	2147483647
	dd	13
	dw	80,97,114,115,105,110,103,32,70,111,110,116,58
