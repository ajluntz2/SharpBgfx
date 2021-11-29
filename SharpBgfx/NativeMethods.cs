using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SharpBgfx {
    [SuppressUnmanagedCodeSecurity]
    unsafe static class NativeMethods {
#pragma warning disable IDE1006 // Naming Styles

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_texture_2d (ushort handle, ushort layer, byte mip, ushort x, ushort y, ushort width, ushort height, MemoryBlock.DataPtr* memory, ushort pitch);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_texture_3d (ushort handle, byte mip, ushort x, ushort y, ushort z, ushort width, ushort height, ushort depth, MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_texture_cube (ushort handle, ushort layer, CubeMapFace side, byte mip, ushort x, ushort y, ushort width, ushort height, MemoryBlock.DataPtr* memory, ushort pitch);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint bgfx_get_avail_transient_index_buffer (uint num, bool index32);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint bgfx_get_avail_transient_vertex_buffer (uint num, ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint bgfx_get_avail_instance_data_buffer (uint num, ushort stride);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_alloc_transient_index_buffer (out TransientIndexBuffer tib, uint num, bool index32);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_alloc_transient_vertex_buffer (out TransientVertexBuffer tvb, uint num, ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool bgfx_alloc_transient_buffers (out TransientVertexBuffer tvb, ref VertexLayout.Data decl, uint numVertices, out TransientIndexBuffer tib, uint numIndices, bool index32);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_alloc_instance_data_buffer (out InstanceDataBuffer.NativeStruct ptr, uint num, ushort stride);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dispatch (ushort id, ushort program, uint numX, uint numY, uint numZ);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)] // flags are DiscardFlags
        public static extern void bgfx_dispatch_indirect (ushort id, ushort program, ushort indirectHandle, ushort start, ushort num, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_texture (byte stage, ushort sampler, ushort texture, uint flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_image (byte stage, ushort texture, byte mip, ComputeBufferAccess access, TextureFormat format);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_compute_index_buffer (byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_compute_vertex_buffer (byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_compute_dynamic_index_buffer (byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_compute_dynamic_vertex_buffer (byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_compute_indirect_buffer (byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer (ushort width, ushort height, TextureFormat format, TextureFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_frame_buffer_name(ushort handle, [MarshalAs(UnmanagedType.LPStr)] string name, int len);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer_scaled (BackbufferRatio ratio, TextureFormat format, TextureFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer_from_handles (byte count, ushort* handles, [MarshalAs(UnmanagedType.U1)] bool destroyTextures);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer_from_attachment (byte count, FrameBuffer.NativeAttachment* attachment, [MarshalAs(UnmanagedType.U1)] bool destroyTextures);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer_from_nwh (IntPtr nwh, ushort width, ushort height, TextureFormat format, TextureFormat depthFormat);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_frame_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_frame_buffer (ushort id, ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_program (ushort vsh, ushort fsh, [MarshalAs(UnmanagedType.U1)] bool destroyShaders);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_compute_program (ushort csh, [MarshalAs(UnmanagedType.U1)] bool destroyShaders);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_program (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Capabilities.Caps* bgfx_get_caps ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref VertexLayout.Data bgfx_vertex_layout_begin(ref VertexLayout.Data decl, RendererBackend backend);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref VertexLayout.Data bgfx_vertex_layout_add(ref VertexLayout.Data decl, VertexAttributeUsage attribute, byte count, VertexAttributeType type, [MarshalAs(UnmanagedType.U1)] bool normalized, [MarshalAs(UnmanagedType.U1)] bool asInt);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref VertexLayout.Data bgfx_vertex_layout_skip(ref VertexLayout.Data decl, byte count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_layout_end(ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_vertex_buffer (MemoryBlock.DataPtr* memory, ref VertexLayout.Data decl, BufferFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_vertex_buffer_name(ushort handle, [MarshalAs(UnmanagedType.LPStr)] string name, int len);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_vertex_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_uniform ([MarshalAs(UnmanagedType.LPStr)] string name, UniformType type, ushort arraySize);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_get_uniform_info (ushort handle, out Uniform.Info info);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_uniform (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture (MemoryBlock.DataPtr* mem, TextureFlags flags, byte skip, out Texture.TextureInfo info);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture_2d (ushort width, ushort _height, [MarshalAs(UnmanagedType.U1)] bool hasMips, ushort numLayers, TextureFormat format, TextureFlags flags, MemoryBlock.DataPtr* mem);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture_2d_scaled (BackbufferRatio ratio, [MarshalAs(UnmanagedType.U1)] bool hasMips, ushort numLayers, TextureFormat format, TextureFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture_3d (ushort width, ushort _height, ushort _depth, [MarshalAs(UnmanagedType.U1)] bool hasMips, TextureFormat format, TextureFlags flags, MemoryBlock.DataPtr* mem);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture_cube (ushort size, [MarshalAs(UnmanagedType.U1)] bool hasMips, ushort numLayers, TextureFormat format, TextureFlags flags, MemoryBlock.DataPtr* mem);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_texture_name(ushort handle, [MarshalAs(UnmanagedType.LPStr)] string name, int len);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bgfx_get_direct_access_ptr (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_texture (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_calc_texture_size (ref Texture.TextureInfo info, ushort width, ushort height, ushort depth, [MarshalAs(UnmanagedType.U1)] bool cubeMap, [MarshalAs(UnmanagedType.U1)] bool hasMips, ushort numLayers, TextureFormat format);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool bgfx_is_texture_valid (ushort depth, [MarshalAs(UnmanagedType.U1)] bool cubeMap, ushort numLayers, TextureFormat format, TextureFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_shader (MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_get_shader_uniforms (ushort handle, Uniform* uniforms, ushort max);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_shader_name(ushort handle, [MarshalAs(UnmanagedType.LPStr)] string name, int len);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_shader (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern MemoryBlock.DataPtr* bgfx_alloc (uint size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern MemoryBlock.DataPtr* bgfx_copy (IntPtr data, uint size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern MemoryBlock.DataPtr* bgfx_make_ref_release (IntPtr data, uint size, IntPtr releaseFn, IntPtr userData);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_index_buffer (MemoryBlock.DataPtr* memory, BufferFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_index_buffer_name(ushort handle, [MarshalAs(UnmanagedType.LPStr)] string name, int len);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_index_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_index_buffer (uint indexCount, BufferFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_index_buffer_mem (MemoryBlock.DataPtr* memory, BufferFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_dynamic_index_buffer (ushort handle, uint startIndex, MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_dynamic_index_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_vertex_buffer (uint vertexCount, ref VertexLayout.Data decl, BufferFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_vertex_buffer_mem (MemoryBlock.DataPtr* memory, ref VertexLayout.Data decl, BufferFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_dynamic_vertex_buffer (ushort handle, uint startVertex, MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_dynamic_vertex_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_indirect_buffer (uint size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_indirect_buffer (ushort handle);

        //[DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        //public static extern void bgfx_image_swizzle_bgra8 (IntPtr dst, int width, int height, int pitch, IntPtr src);

        //[DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        //public static extern void bgfx_image_rgba8_downsample_2x2 (IntPtr dst, int width, int height, int pitch, IntPtr src);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_platform_data (ref PlatformData data);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern InternalData* bgfx_get_internal_data ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern RenderFrameResult bgfx_render_frame (int timeoutMs);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bgfx_override_internal_texture_ptr (ushort handle, IntPtr ptr);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bgfx_override_internal_texture (ushort handle, ushort width, ushort height, byte numMips, TextureFormat format, TextureFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern PerfStats.Stats* bgfx_get_stats ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern RendererBackend bgfx_get_renderer_type ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_shutdown ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_reset (uint width, uint height, ResetFlags flags, TextureFormat format);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint bgfx_frame ([MarshalAs(UnmanagedType.U1)] bool capture);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_debug (DebugFeatures flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_marker ([MarshalAs(UnmanagedType.LPStr)] string marker);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dbg_text_clear (byte color, [MarshalAs(UnmanagedType.U1)] bool smallText);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint bgfx_set_transform (void* matrix, ushort count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_stencil (uint frontFace, uint backFace);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_touch (ushort id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_submit (ushort id, ushort programHandle, uint depth, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_submit_occlusion_query (ushort id, ushort programHandle, ushort queryHandle, uint depth, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_submit_indirect (ushort id, ushort programHandle, ushort indirectHandle, ushort start, ushort num, uint depth, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_discard (byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_name (ushort id, [MarshalAs(UnmanagedType.LPStr)] string name);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_rect (ushort id, ushort x, ushort y, ushort width, ushort height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_rect_ratio (ushort id, ushort x, ushort y, BackbufferRatio ratio);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_scissor (ushort id, ushort x, ushort y, ushort width, ushort height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_clear (ushort id, ClearTargets flags, uint rgba, float depth, byte stencil);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_clear_mrt (ushort id, ClearTargets flags, float depth, byte stencil, byte rt0, byte rt1, byte rt2, byte rt3, byte rt4, byte rt5, byte rt6, byte rt7);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_palette_color (byte index, float* color);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_mode (ushort id, ViewMode mode);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_transform (ushort id, void* view, void* proj);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_request_screen_shot (ushort handle, [MarshalAs(UnmanagedType.LPStr)] string filePath);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_state (ulong state, uint rgba);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_pack (float* input, [MarshalAs(UnmanagedType.U1)] bool inputNormalized, VertexAttributeUsage attribute, ref VertexLayout.Data decl, IntPtr data, uint index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_unpack (float* output, VertexAttributeUsage attribute, ref VertexLayout.Data decl, IntPtr data, uint index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_convert (ref VertexLayout.Data destDecl, IntPtr destData, ref VertexLayout.Data srcDecl, IntPtr srcData, uint num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_weld_vertices (ushort* output, ref VertexLayout.Data decl, IntPtr data, ushort num, bool index32, float epsilon);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte bgfx_get_supported_renderers (byte max, RendererBackend[] backends);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* bgfx_get_renderer_name (RendererBackend backend);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_init_ctor (InitSettings.Native* ptr);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool bgfx_init (InitSettings.Native* ptr);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dbg_text_printf (ushort x, ushort y, byte color, [MarshalAs(UnmanagedType.LPStr)] string format, [MarshalAs(UnmanagedType.LPStr)] string args);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dbg_text_printf (ushort x, ushort y, byte color, byte* format, IntPtr args);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dbg_text_image (ushort x, ushort y, ushort width, ushort height, IntPtr data, ushort pitch);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_index_buffer (ushort handle, uint firstIndex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_dynamic_index_buffer (ushort handle, uint firstIndex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_vertex_buffer (byte stream, ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_dynamic_vertex_buffer (byte stream, ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_uniform (ushort handle, void* value, ushort arraySize);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_transform_cached (uint cache, ushort num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_set_scissor (ushort x, ushort y, ushort width, ushort height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_scissor_cached (ushort cache);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_transient_vertex_buffer (byte stream, ref TransientVertexBuffer tvb, uint startVertex, uint numVertices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_transient_index_buffer (ref TransientIndexBuffer tib, uint startIndex, uint numIndices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_vertex_count (uint numVertices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_instance_count (uint numInstances);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_instance_data_buffer (ref InstanceDataBuffer.NativeStruct idb, uint start, uint num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_instance_data_from_vertex_buffer (ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_instance_data_from_dynamic_vertex_buffer (ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_reset_view (ushort id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_blit (ushort id, ushort dst, byte dstMip, ushort dstX, ushort dstY, ushort dstZ, ushort src,
                                             byte srcMip, ushort srcX, ushort srcY, ushort srcZ, ushort width, ushort height, ushort depth);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint bgfx_read_texture (ushort handle, IntPtr data, byte mip);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_get_texture (ushort handle, byte attachment);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_occlusion_query ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_occlusion_query (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern OcclusionQueryResult bgfx_get_result (ushort handle, int* pixels);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_condition (ushort handle, [MarshalAs(UnmanagedType.U1)] bool visible);

        // This no longer is available, not really sure why.
        //   [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        //   public static extern int bgfx_vsnprintf(sbyte* str, IntPtr count, [MarshalAs(UnmanagedType.LPStr)] string format, IntPtr argList);
        
        // Seperate library used here, very simple:
        //CUtils_API int CUtils_vsnprintf(char * s, size_t n, const char * format, va_list arg)
        // {
        //    return vsnprintf(s, n, format, arg);
        // }
#if _LINUX
        const string UtilsDllName = "CUtils.so";
#elif _OSX
        const string UtilsDllName = "CUtils.dylib";
#else // _WINDOWS
        const string UtilsDllName = "CUtils.dll";
#endif
        [DllImport(UtilsDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int CUtils_vsnprintf(sbyte* str, IntPtr count, [MarshalAs(UnmanagedType.LPStr)] string format, IntPtr argList);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bgfx_encoder_begin (bool forThread);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_end (IntPtr encoder);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_marker (IntPtr encoder, [MarshalAs(UnmanagedType.LPStr)] string marker);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_state (IntPtr encoder, ulong state, int rgba);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_condition (IntPtr encoder, ushort handle, [MarshalAs(UnmanagedType.U1)] bool visible);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_stencil(IntPtr encoder, uint frontFace, uint backFace);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_encoder_set_scissor(IntPtr encoder, ushort x, ushort y, ushort width, ushort height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_scissor_cached(IntPtr encoder, ushort cache);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint bgfx_encoder_set_transform(IntPtr encoder, void* matrix, ushort count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_transform_cached(IntPtr encoder, uint cache, ushort num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_uniform(IntPtr encoder, ushort handle, void* value, ushort arraySize);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_index_buffer(IntPtr encoder, ushort handle, uint firstIndex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_dynamic_index_buffer(IntPtr encoder, ushort handle, uint firstIndex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_vertex_buffer(IntPtr encoder, byte stream, ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_dynamic_vertex_buffer(IntPtr encoder, byte stream, ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_transient_vertex_buffer(IntPtr encoder, byte stream, ref TransientVertexBuffer tvb, uint startVertex, uint numVertices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_transient_index_buffer(IntPtr encoder, ref TransientIndexBuffer tib, uint startIndex, uint numIndices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_vertex_count (IntPtr encoder, uint numVertices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_instance_data_buffer(IntPtr encoder, ref InstanceDataBuffer.NativeStruct idb, uint start, uint num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_instance_data_from_vertex_buffer(IntPtr encoder, ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_instance_data_from_dynamic_vertex_buffer(IntPtr encoder, ushort handle, uint startVertex, uint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_texture(IntPtr encoder, byte stage, ushort sampler, ushort texture, uint flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_touch(IntPtr encoder, ushort id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_submit(IntPtr encoder, ushort id, ushort programHandle, uint depth, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_submit_occlusion_query(IntPtr encoder, ushort id, ushort programHandle, ushort queryHandle, uint depth, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_submit_indirect(IntPtr encoder, ushort id, ushort programHandle, ushort indirectHandle, ushort start, ushort num, uint depth, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_image(IntPtr encoder, byte stage, ushort texture, byte mip, ComputeBufferAccess access, TextureFormat format);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_compute_index_buffer(IntPtr encoder, byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_compute_vertex_buffer(IntPtr encoder, byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_compute_dynamic_index_buffer(IntPtr encoder, byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_compute_dynamic_vertex_buffer(IntPtr encoder, byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_set_compute_indirect_buffer(IntPtr encoder, byte stage, ushort handle, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_dispatch(IntPtr encoder, ushort id, ushort program, uint numX, uint numY, uint numZ, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_dispatch_indirect(IntPtr encoder, ushort id, ushort program, ushort indirectHandle, ushort start, ushort num, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_discard(IntPtr encoder, byte flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_encoder_blit(IntPtr encoder, ushort id, ushort dst, byte dstMip, ushort dstX, ushort dstY, ushort dstZ, ushort src,
                                                    byte srcMip, ushort srcX, ushort srcY, ushort srcZ, ushort width, ushort height, ushort depth);

#pragma warning restore IDE1006 // Naming Styles
#if _OSX
      const string DllName = "bgfx.dylib";
#elif _LINUX
      const string DllName = "bgfx.so";
#else // _WINDOWS
      const string DllName = "bgfx.dll";
#endif
   }
}
