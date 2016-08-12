# License Applicability. Except to the extent portions of this file are
# made subject to an alternative license as permitted in the SGI Free
# Software License B, Version 1.1 (the "License"), the contents of this
# file are subject only to the provisions of the License. You may not use
# this file except in compliance with the License. You may obtain a copy
# of the License at Silicon Graphics, Inc., attn: Legal Services, 1600
# Amphitheatre Parkway, Mountain View, CA 94043-1351, or at:
#
# http://oss.sgi.com/projects/FreeB
#
# Note that, as provided in the License, the Software is distributed on an
# "AS IS" basis, with ALL EXPRESS AND IMPLIED WARRANTIES AND CONDITIONS
# DISCLAIMED, INCLUDING, WITHOUT LIMITATION, ANY IMPLIED WARRANTIES AND
# CONDITIONS OF MERCHANTABILITY, SATISFACTORY QUALITY, FITNESS FOR A
# PARTICULAR PURPOSE, AND NON-INFRINGEMENT.
#
# Original Code. The Original Code is: OpenGL Sample Implementation,
# Version 1.2.1, released January 26, 2000, developed by Silicon Graphics,
# Inc. The Original Code is Copyright (c) 1991-2005 Silicon Graphics, Inc.
# Copyright in any portions created by third parties is as indicated
# elsewhere herein. All Rights Reserved.
#
# Additional Notice Provisions: This software was created using the
# OpenGL(R) version 1.2.1 Sample Implementation published by SGI, but has
# not been independently verified as being compliant with the OpenGL(R)
# version 1.2.1 Specification.

required-props:
param:		retval retained
dlflags:	notlistable handcode nop
glxflags:	client-handcode server-handcode
glxvendorglx:	*
vectorequiv:	*
category:	pixel-rw bgn-end display-list drawing drawing-control feedback framebuf misc modeling pixel-op pixel-rw state-req xform glx glxopcode
glxopcode:		*

###############################################################################
#
# GLX1.0 commands
#
###############################################################################
Render()
	return		 void
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 1


RenderLarge()
	return		 void
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 2


CreateContext(gc_id, screen, visual, share_list)
	return		 void
	param		 gc_id		Int32 in value
	param		 screen		Int32 in value
	param		 visual		Int32 in value
	param		 share_list	Int32 in value
	glxflags	 client-handcode server-handcode
	category	 glx
	dlflags		 notlistable
	glxopcode	 3


DestroyContext(context)
	return		 void
	param		 context       Int32 in value
	glxflags	 client-handcode server-handcode
	category	 glx
	dlflags		 notlistable
	glxopcode	 4


MakeCurrent(drawable, context)
	return		 void
	param		 drawable	Int32 in value
	param		 context       Int32 in value
	glxflags	 client-handcode server-handcode
	category	 glx
	dlflags		 notlistable
	glxopcode	 5


IsDirect(dpy, context)
	return		void
	param		dpy		Int32 in value
	param		context		Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxopcode	6


QueryVersion(major, minor)
	return		 void
	param		 major		Int32 out reference
	param		 minor		Int32 out reference
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 7


WaitGL(context)
	return		 void
	param		 context	Int32 in value
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 8


WaitX()
	return		 void
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 9


CopyContext(source, dest, mask)
	return		 void
	param		 source		Int32 in value
	param		 dest		Int32 in value
	param		 mask		Int32 in value
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 10


SwapBuffers(drawable)
	return		 void
	param		 drawable	Int32 in value
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 11


UseXFont(font, first, count, list_base)
	return		 void
	param		 font		Int32 in value
	param		 first		Int32 in value
	param		 count		Int32 in value
	param		 list_base	Int32 in value
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 12


CreateGLXPixmap(visual, pixmap, glxpixmap)
	return		 void
	param		 visual		Int32 in value
	param		 pixmap		Int32 in value
	param		 glxpixmap	Int32 in value
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 13

GetVisualConfigs()
	return		 void
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxopcode	 14


DestroyGLXPixmap(pixmap)
	return		 void
	param		 pixmap		Int32 in value
	glxflags	 client-handcode
	category	 glx
	dlflags		 notlistable
	glxopcode	 15


VendorPrivate()
	return		void
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxopcode	16


VendorPrivateWithReply()
	return		void
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxopcode	17

###############################################################################
#
# GLX1.1 commands
#
###############################################################################
QueryExtensionsString(screen)
	return		void
	param		screen		Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxopcode	18

QueryServerString(screen, name)
	return		void
	param		screen		Int32 in value
	param		name		Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxopcode	19

ClientInfo()
	return		void
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxopcode	20

###############################################################################
#
# GLX1.3 commands
#
###############################################################################
GetFBConfigs()
	return		void
	category	glx
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	glxopcode	21

CreatePixmap(config, pixmap, glxpixmap)
	return		void
	param		config		Int32 in value
	param		pixmap		Int32 in value
	param		glxpixmap	Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	22

DestroyPixmap(glxpixmap)
	return		void
	param		glxpixmap	Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	23

CreateNewContext(config, render_type, share_list, direct)
	return		void
	param		config		Int32 in value
	param		render_type	Int32 in value
	param		share_list	Int32 in value
	param		direct		Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	24

QueryContext()
	return		void
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	25

MakeContextCurrent(drawable, readdrawable, context)
	return		void
	param		drawable	Int32 in value
	param		readdrawable	Int32 in value
	param		context		Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	26

CreatePbuffer(config, pbuffer)
	return		void
	param		config		Int32 in value
	param		pbuffer		Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	27

DestroyPbuffer(pbuffer)
	return		void
	param		pbuffer		Int32 in value
	dlflags		notlistable
	glxflags	client-handcode
	category	glx
	glxopcode	28

GetDrawableAttributes(drawable)
	return		void
	param		drawable	Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	29

ChangeDrawableAttributes(drawable)
	return		void
	param		drawable	Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	30

CreateWindow(config, window, glxwindow)
	return		void
	param		config		Int32 in value
	param		window		Int32 in value
	param		glxwindow	Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	31

DestroyWindow(glxwindow)
	return		void
	param		glxwindow	Int32 in value
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	glx
	glxopcode	32

###############################################################################
#
# IRIX5.3 extension commands
#
###############################################################################

###############################################################################
#
# SGI_swap_control extension commands
#
###############################################################################
SwapIntervalSGI()
	return		void
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65536

###############################################################################
#
# IRIX5.3-PATCH154 extension commands
#
###############################################################################

###############################################################################
#
# SGI_make_current_read extension commands
#
###############################################################################
MakeCurrentReadSGI(drawable, readdrawable, context)
	return		void
	param		drawable	Int32 in value
	param		readdrawable	Int32 in value
	param		context		Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65537

###############################################################################
#
# SGIX_video_source extension commands
#
###############################################################################
CreateGLXVideoSourceSGIX(dpy, screen, server, path, class, node)
	return		void
	param		dpy			Int32 in value
	param		screen			Int32 in value
	param		server			Int32 in value
	param		path			Int32 in value
	param		class			Int32 in value
	param		node			Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65538

DestroyGLXVideoSourceSGIX(dpy, glxvideosource)
	return		void
	param		dpy			Int32 in value
	param		glxvideosource		Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65539

###############################################################################
#
# IRIX6.2 extension commands
#
###############################################################################

###############################################################################
#
# EXT_import_context extension commands
#
###############################################################################
QueryContextInfoEXT()
	return		 void
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxvendorglx	 1024

###############################################################################
#
# SGIX_fbconfig extension commands
#
###############################################################################
GetFBConfigsSGIX()
	return		 void
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxvendorglx	 65540

CreateContextWithConfigSGIX(gc_id, screen, config, share_list)
	return		 void
	param		 gc_id		Int32 in value
	param		 screen		Int32 in value
	param		 config		Int32 in value
	param		 share_list	Int32 in value
	glxflags	 client-handcode server-handcode
	category	 glx
	dlflags		 notlistable
	glxvendorglx	 65541

CreateGLXPixmapWithConfigSGIX(config, pixmap, glxpixmap)
	return		 void
	param		 config		Int32 in value
	param		 pixmap		Int32 in value
	param		 glxpixmap	Int32 in value
	category	 glx
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	glxvendorglx	 65542

###############################################################################
#
# SGIX_pbuffer extension commands
#
###############################################################################

CreateGLXPbufferSGIX(config, pbuffer)
	return		 void
	param		 config		Int32 in value
	param		 pbuffer	Int32 in value
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	category	 glx
	glxvendorglx	 65543

DestroyGLXPbufferSGIX(pbuffer)
	return		 void
	param		 pbuffer	Int32 in value
	dlflags		 notlistable
	glxflags	 client-handcode
	category	 glx
	glxvendorglx	 65544

ChangeDrawableAttributesSGIX(drawable)
	return		 void
	param		 drawable	Int32 in value
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	category	 glx
	glxvendorglx	 65545

GetDrawableAttributesSGIX(drawable)
	return		 void
	param		 drawable	Int32 in value
	dlflags		 notlistable
	glxflags	 client-handcode server-handcode
	category	 glx
	glxvendorglx	 65546

###############################################################################
#
# SGIX_swap_group extension commands
#
###############################################################################

JoinSwapGroupSGIX(window,group)
	return		void
	param		window		Int32 in value
	param		group		Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65547

###############################################################################
#
# SGIX_swap_barrier extension commands
#
###############################################################################

BindSwapBarrierSGIX(window,barrier)
	return		void
	param		window		Int32 in value
	param		barrier		Int32 in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65548

QueryMaxSwapBarriersSGIX()
	return		void
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65549

###############################################################################
#
# SGIX_hyperpipe extension commands
#
###############################################################################

QueryHyperpipeNetworkSGIX(dpy, npipes)
	return		GLXHyperpipeNetworkPointer
	param		dpy		Display out reference
	param		npipes		int out reference
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65550

HyperpipeConfigSGIX(dpy, networkId, npipes, cfg, hpId)
	return		int
	param		dpy		Display out reference
	param		networkId	int in value
	param		npipes		int in value
	param		cfg		GLXHyperpipeConfig in array[npipes]
	param		hpId		int out reference
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65552

QueryHyperpipeConfigSGIX(dpy, hpId, npipes)
	return		GLXHyperpipeConfigPointer
	param		dpy		Display out reference
	param		hpId		int in value
	param		npipes		int out reference
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65551

DestroyHyperpipeConfigSGIX(dpy, hpId)
	return		int
	param		dpy		Display out reference
	param		hpId		int in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	65553

BindHyperpipeSGIX(dpy, hpId)
	return		int
	param		dpy		Display out reference
	param		hpId		int in value
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	???

QueryHyperpipeBestAttribSGIX(dpy, timeSlice, attrib, size, attribList, returnAttribList)
	return		int
	param		dpy		Display out reference
	param		timeSlice	int in value
	param		attrib		int in value
	param		size		int in value
	param		attribList	Void in array[size]
	param		returnAttribList Void out array[size]
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	???

HyperpipeAttribSGIX(dpy, timeSlice, attrib, size, attribList)
	return		int
	param		dpy		Display out reference
	param		timeSlice	int in value
	param		attrib		int in value
	param		size		int in value
	param		attribList	void in array[size]
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	???

QueryHyperpipeAttribSGIX(dpy, timeSlice, attrib, size, returnAttribList)
	return		int
	param		dpy		Display out reference
	param		timeSlice	int in value
	param		attrib		int in value
	param		size		int in value
	param		returnAttribList void out array[size]		# Changed in to out
	glxflags	client-handcode server-handcode
	category	glx
	dlflags		notlistable
	glxvendorglx	???
