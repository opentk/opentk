//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

namespace OpenTK.Compute.CL10
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    using OpenTK.Extensions;


    /// <summary>
    /// Defines methods to simplify CommandQueue usage.
    /// </summary>
    public partial struct CommandQueue : IComparable<CommandQueue>, IEquatable<CommandQueue>
    {
        internal IntPtr Value;

        #region IComparable<CommandQueue> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="CommandQueue"/>.
        /// </summary>
        /// <param name="other">The <see cref="CommandQueue"/> to compare with the current <see cref="CommandQueue"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(CommandQueue other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<CommandQueue> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="CommandQueue"/> is equal to the current <see cref="CommandQueue"/>.
        /// </summary>
        /// <param name="other">The <see cref="CommandQueue"/> to compare with the current <see cref="CommandQueue"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="CommandQueue"/> is equal to the current
        /// <see cref="CommandQueue"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(CommandQueue other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="CommandQueue"/></summary>
        public static readonly CommandQueue Zero = new CommandQueue();

        /// <summary>Tests two <see cref="CommandQueue"/> instances for equality.</summary>
        public static bool operator ==(CommandQueue left, CommandQueue right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="CommandQueue"/> instances for inequality.</summary>
        public static bool operator !=(CommandQueue left, CommandQueue right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="CommandQueue"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="CommandQueue"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="CommandQueue"/> is equal to the current
        /// <see cref="CommandQueue"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is CommandQueue && Equals((CommandQueue)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="CommandQueue"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify CommandQueue usage.
    /// </summary>
    public static partial class CommandQueueExtensions
    {
        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="src_buffer"></param>
        /// <param name="dst_buffer"></param>
        /// <param name="src_offset"></param>
        /// <param name="dst_offset"></param>
        /// <param name="cb"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueCopyBuffer(this CommandQueue command_queue, ComputeMemory src_buffer, ComputeMemory dst_buffer, IntPtr src_offset, IntPtr dst_offset, IntPtr cb, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, cb, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="src_buffer"></param>
        /// <param name="dst_buffer"></param>
        /// <param name="src_offset"></param>
        /// <param name="dst_offset"></param>
        /// <param name="cb"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueCopyBuffer(this CommandQueue command_queue, ComputeMemory src_buffer, ComputeMemory dst_buffer, IntPtr src_offset, IntPtr dst_offset, IntPtr cb, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, cb, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="src_buffer"></param>
        /// <param name="dst_buffer"></param>
        /// <param name="src_offset"></param>
        /// <param name="dst_offset"></param>
        /// <param name="cb"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueCopyBuffer(this CommandQueue command_queue, ComputeMemory src_buffer, ComputeMemory dst_buffer, IntPtr src_offset, IntPtr dst_offset, IntPtr cb, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
        {
            return CL.EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, cb, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="kernel"></param>
        /// <param name="work_dim"></param>
        /// <param name="global_work_offset"></param>
        /// <param name="global_work_size"></param>
        /// <param name="local_work_size"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueNDRangeKernel(this CommandQueue command_queue, ComputeKernel kernel, Int32 work_dim, IntPtr[] global_work_offset, IntPtr[] global_work_size, IntPtr[] local_work_size, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueNDRangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="kernel"></param>
        /// <param name="work_dim"></param>
        /// <param name="global_work_offset"></param>
        /// <param name="global_work_size"></param>
        /// <param name="local_work_size"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueNDRangeKernel(this CommandQueue command_queue, ComputeKernel kernel, Int32 work_dim, ref IntPtr global_work_offset, ref IntPtr global_work_size, ref IntPtr local_work_size, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueNDRangeKernel(command_queue, kernel, work_dim, ref global_work_offset, ref global_work_size, ref local_work_size, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="kernel"></param>
        /// <param name="work_dim"></param>
        /// <param name="global_work_offset"></param>
        /// <param name="global_work_size"></param>
        /// <param name="local_work_size"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueNDRangeKernel(this CommandQueue command_queue, ComputeKernel kernel, Int32 work_dim, IntPtr* global_work_offset, IntPtr* global_work_size, IntPtr* local_work_size, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
        {
            return CL.EnqueueNDRangeKernel(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, IntPtr ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, IntPtr ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueReadBuffer(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, IntPtr ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[] ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[] ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[] ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,] ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,] ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,] ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,,] ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,,] ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,,] ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] ref T5 ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ref ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] ref T5 ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ref ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_read"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueReadBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_read, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] ref T5 ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, cb, ref ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, IntPtr ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, IntPtr ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueWriteBuffer(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, IntPtr ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[] ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[] ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[] ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,] ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,] ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,] ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,,] ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,,] ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] T5[,,] ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] ref T5 ptr, Int32 num_events_in_wait_list, ComputeEvent[] event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ref ptr, num_events_in_wait_list, event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] ref T5 ptr, Int32 num_events_in_wait_list, ref ComputeEvent event_wait_list, [OutAttribute] out ComputeEvent @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ref ptr, num_events_in_wait_list, ref event_wait_list, out @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        /// <param name="buffer"></param>
        /// <param name="blocking_write"></param>
        /// <param name="offset"></param>
        /// <param name="cb"></param>
        /// <param name="ptr"></param>
        /// <param name="num_events_in_wait_list"></param>
        /// <param name="event_wait_list"></param>
        /// <param name="event"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode EnqueueWriteBuffer<T5>(this CommandQueue command_queue, ComputeMemory buffer, bool blocking_write, IntPtr offset, IntPtr cb, [InAttribute, OutAttribute] ref T5 ptr, Int32 num_events_in_wait_list, ComputeEvent* event_wait_list, [OutAttribute] ComputeEvent* @event)
            where T5 : struct
        
        {
            return CL.EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, cb, ref ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="command_queue"></param>
        public static ErrorCode Finish(this CommandQueue command_queue)
        {
            return CL.Finish(command_queue);
        }

    }

    /// <summary>
    /// Defines methods to simplify ComputeContext usage.
    /// </summary>
    public partial struct ComputeContext : IComparable<ComputeContext>, IEquatable<ComputeContext>
    {
        internal IntPtr Value;

        #region IComparable<ComputeContext> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputeContext"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeContext"/> to compare with the current <see cref="ComputeContext"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputeContext other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputeContext> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputeContext"/> is equal to the current <see cref="ComputeContext"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeContext"/> to compare with the current <see cref="ComputeContext"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeContext"/> is equal to the current
        /// <see cref="ComputeContext"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputeContext other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputeContext"/></summary>
        public static readonly ComputeContext Zero = new ComputeContext();

        /// <summary>Tests two <see cref="ComputeContext"/> instances for equality.</summary>
        public static bool operator ==(ComputeContext left, ComputeContext right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputeContext"/> instances for inequality.</summary>
        public static bool operator !=(ComputeContext left, ComputeContext right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputeContext"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputeContext"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeContext"/> is equal to the current
        /// <see cref="ComputeContext"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputeContext && Equals((ComputeContext)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputeContext"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="properties"></param>
        /// <param name="num_devices"></param>
        /// <param name="devices"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeContext CreateContext(IntPtr[] properties, Int32 num_devices, ComputeDevice[] devices, ContextNotifyDelegate pfn_notify, IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateContext(properties, num_devices, devices, pfn_notify, user_data, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="properties"></param>
        /// <param name="num_devices"></param>
        /// <param name="devices"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeContext CreateContext(ref IntPtr properties, Int32 num_devices, ref ComputeDevice devices, ContextNotifyDelegate pfn_notify, IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateContext(ref properties, num_devices, ref devices, pfn_notify, user_data, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="properties"></param>
        /// <param name="num_devices"></param>
        /// <param name="devices"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeContext CreateContext(IntPtr* properties, Int32 num_devices, ComputeDevice* devices, ContextNotifyDelegate pfn_notify, IntPtr user_data, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateContext(properties, num_devices, devices, pfn_notify, user_data, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="properties"></param>
        /// <param name="device_type"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeContext CreateContextFromType(IntPtr[] properties, DeviceTypeFlags device_type, ContextNotifyDelegate pfn_notify, IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateContextFromType(properties, device_type, pfn_notify, user_data, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="properties"></param>
        /// <param name="device_type"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeContext CreateContextFromType(ref IntPtr properties, DeviceTypeFlags device_type, ContextNotifyDelegate pfn_notify, IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateContextFromType(ref properties, device_type, pfn_notify, user_data, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="properties"></param>
        /// <param name="device_type"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeContext CreateContextFromType(IntPtr* properties, DeviceTypeFlags device_type, ContextNotifyDelegate pfn_notify, IntPtr user_data, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateContextFromType(properties, device_type, pfn_notify, user_data, errcode_ret);
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputeContext usage.
    /// </summary>
    public static partial class ComputeContextExtensions
    {
        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, IntPtr host_ptr, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, IntPtr host_ptr, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[] host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[] host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,] host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,] host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,,] host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,,] host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] ref T3 host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, ref host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] ref T3 host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        
        {
            return CL.CreateBuffer(context, flags, size, ref host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="device"></param>
        /// <param name="properties"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static CommandQueue CreateCommandQueue(this ComputeContext context, ComputeDevice device, CommandQueueFlags properties, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateCommandQueue(context, device, properties, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="device"></param>
        /// <param name="properties"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe CommandQueue CreateCommandQueue(this ComputeContext context, ComputeDevice device, CommandQueueFlags properties, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateCommandQueue(context, device, properties, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, IntPtr host_ptr, [OutAttribute] Int32[] errcode_ret)
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[] host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[,] host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[,,] host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] ref T6 host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, ref host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, IntPtr host_ptr, [OutAttribute] out Int32 errcode_ret)
        {
            return CL.CreateImage2D(context, flags, ref image_format, image_width, image_height, image_row_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[] host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, ref image_format, image_width, image_height, image_row_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[,] host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, ref image_format, image_width, image_height, image_row_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[,,] host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, ref image_format, image_width, image_height, image_row_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] ref T6 host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, ref image_format, image_width, image_height, image_row_pitch, ref host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, IntPtr host_ptr, [OutAttribute] Int32* errcode_ret)
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[] host_ptr, [OutAttribute] Int32* errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[,] host_ptr, [OutAttribute] Int32* errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] T6[,,] host_ptr, [OutAttribute] Int32* errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T6>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, [InAttribute, OutAttribute] ref T6 host_ptr, [OutAttribute] Int32* errcode_ret)
            where T6 : struct
        
        {
            return CL.CreateImage2D(context, flags, image_format, image_width, image_height, image_row_pitch, ref host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr host_ptr, [OutAttribute] Int32[] errcode_ret)
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[] host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[,] host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[,,] host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat[] image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] ref T8 host_ptr, [OutAttribute] Int32[] errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, ref host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr host_ptr, [OutAttribute] out Int32 errcode_ret)
        {
            return CL.CreateImage3D(context, flags, ref image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[] host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, ref image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[,] host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, ref image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[,,] host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, ref image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ref ImageFormat image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] ref T8 host_ptr, [OutAttribute] out Int32 errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, ref image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, ref host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr host_ptr, [OutAttribute] Int32* errcode_ret)
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[] host_ptr, [OutAttribute] Int32* errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[,] host_ptr, [OutAttribute] Int32* errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] T8[,,] host_ptr, [OutAttribute] Int32* errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_format"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T8>(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, [InAttribute, OutAttribute] ref T8 host_ptr, [OutAttribute] Int32* errcode_ret)
            where T8 : struct
        
        {
            return CL.CreateImage3D(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, ref host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="count"></param>
        /// <param name="strings"></param>
        /// <param name="lengths"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeProgram CreateProgramWithSource(this ComputeContext context, Int32 count, IntPtr strings, IntPtr* lengths, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="count"></param>
        /// <param name="strings"></param>
        /// <param name="lengths"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeProgram CreateProgramWithSource(this ComputeContext context, Int32 count, String[] strings, IntPtr[] lengths, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateProgramWithSource(context, count, strings, lengths, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="count"></param>
        /// <param name="strings"></param>
        /// <param name="lengths"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeProgram CreateProgramWithSource(this ComputeContext context, Int32 count, ref String strings, ref IntPtr lengths, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateProgramWithSource(context, count, ref strings, ref lengths, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="normalized_coords"></param>
        /// <param name="addressing_mode"></param>
        /// <param name="filter_mode"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeSampler CreateSampler(this ComputeContext context, bool normalized_coords, OpenTK.Compute.CL10.AddressingMode addressing_mode, OpenTK.Compute.CL10.FilterMode filter_mode, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateSampler(context, normalized_coords, addressing_mode, filter_mode, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="normalized_coords"></param>
        /// <param name="addressing_mode"></param>
        /// <param name="filter_mode"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeSampler CreateSampler(this ComputeContext context, bool normalized_coords, OpenTK.Compute.CL10.AddressingMode addressing_mode, OpenTK.Compute.CL10.FilterMode filter_mode, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateSampler(context, normalized_coords, addressing_mode, filter_mode, errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, ref param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContext context, OpenTK.Compute.CL10.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetContextInfo(context, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, ref param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL10.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="image_formats"></param>
        /// <param name="num_image_formats"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetSupportedImageFormats(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, OpenTK.Compute.CL10.MemObjectType image_type, Int32 num_entries, ImageFormat[] image_formats, Int32[] num_image_formats)
        {
            return CL.GetSupportedImageFormats(context, flags, image_type, num_entries, image_formats, num_image_formats);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="image_formats"></param>
        /// <param name="num_image_formats"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetSupportedImageFormats(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, OpenTK.Compute.CL10.MemObjectType image_type, Int32 num_entries, ref ImageFormat image_formats, ref Int32 num_image_formats)
        {
            return CL.GetSupportedImageFormats(context, flags, image_type, num_entries, ref image_formats, ref num_image_formats);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="image_formats"></param>
        /// <param name="num_image_formats"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetSupportedImageFormats(this ComputeContext context, OpenTK.Compute.CL10.MemFlags flags, OpenTK.Compute.CL10.MemObjectType image_type, Int32 num_entries, ImageFormat* image_formats, Int32* num_image_formats)
        {
            return CL.GetSupportedImageFormats(context, flags, image_type, num_entries, image_formats, num_image_formats);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        public static ErrorCode ReleaseContext(this ComputeContext context)
        {
            return CL.ReleaseContext(context);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="context"></param>
        public static ErrorCode RetainContext(this ComputeContext context)
        {
            return CL.RetainContext(context);
        }

    }

    /// <summary>
    /// Defines methods to simplify ComputeDevice usage.
    /// </summary>
    public partial struct ComputeDevice : IComparable<ComputeDevice>, IEquatable<ComputeDevice>
    {
        internal IntPtr Value;

        #region IComparable<ComputeDevice> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputeDevice"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeDevice"/> to compare with the current <see cref="ComputeDevice"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputeDevice other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputeDevice> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputeDevice"/> is equal to the current <see cref="ComputeDevice"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeDevice"/> to compare with the current <see cref="ComputeDevice"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeDevice"/> is equal to the current
        /// <see cref="ComputeDevice"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputeDevice other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputeDevice"/></summary>
        public static readonly ComputeDevice Zero = new ComputeDevice();

        /// <summary>Tests two <see cref="ComputeDevice"/> instances for equality.</summary>
        public static bool operator ==(ComputeDevice left, ComputeDevice right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputeDevice"/> instances for inequality.</summary>
        public static bool operator !=(ComputeDevice left, ComputeDevice right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputeDevice"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputeDevice"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeDevice"/> is equal to the current
        /// <see cref="ComputeDevice"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputeDevice && Equals((ComputeDevice)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputeDevice"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputeDevice usage.
    /// </summary>
    public static partial class ComputeDeviceExtensions
    {
        /// <summary>[requires: v1.0]</summary>
        /// <param name="platform"></param>
        /// <param name="device_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="devices"></param>
        /// <param name="num_devices"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceIDs(this ComputePlatform platform, DeviceTypeFlags device_type, Int32 num_entries, ComputeDevice[] devices, [OutAttribute] out Int32 num_devices)
        {
            return CL.GetDeviceIDs(platform, device_type, num_entries, devices, out num_devices);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="platform"></param>
        /// <param name="device_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="devices"></param>
        /// <param name="num_devices"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceIDs(this ComputePlatform platform, DeviceTypeFlags device_type, Int32 num_entries, ref ComputeDevice devices, [OutAttribute] out Int32 num_devices)
        {
            return CL.GetDeviceIDs(platform, device_type, num_entries, ref devices, out num_devices);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="platform"></param>
        /// <param name="device_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="devices"></param>
        /// <param name="num_devices"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceIDs(this ComputePlatform platform, DeviceTypeFlags device_type, Int32 num_entries, ComputeDevice* devices, [OutAttribute] Int32* num_devices)
        {
            return CL.GetDeviceIDs(platform, device_type, num_entries, devices, num_devices);
        }

    }

    /// <summary>
    /// Defines methods to simplify ComputeEvent usage.
    /// </summary>
    public partial struct ComputeEvent : IComparable<ComputeEvent>, IEquatable<ComputeEvent>
    {
        internal IntPtr Value;

        #region IComparable<ComputeEvent> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputeEvent"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeEvent"/> to compare with the current <see cref="ComputeEvent"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputeEvent other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputeEvent> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputeEvent"/> is equal to the current <see cref="ComputeEvent"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeEvent"/> to compare with the current <see cref="ComputeEvent"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeEvent"/> is equal to the current
        /// <see cref="ComputeEvent"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputeEvent other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputeEvent"/></summary>
        public static readonly ComputeEvent Zero = new ComputeEvent();

        /// <summary>Tests two <see cref="ComputeEvent"/> instances for equality.</summary>
        public static bool operator ==(ComputeEvent left, ComputeEvent right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputeEvent"/> instances for inequality.</summary>
        public static bool operator !=(ComputeEvent left, ComputeEvent right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputeEvent"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputeEvent"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeEvent"/> is equal to the current
        /// <see cref="ComputeEvent"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputeEvent && Equals((ComputeEvent)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputeEvent"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputeEvent usage.
    /// </summary>
    public static partial class ComputeEventExtensions
    {
    }

    /// <summary>
    /// Defines methods to simplify ComputeKernel usage.
    /// </summary>
    public partial struct ComputeKernel : IComparable<ComputeKernel>, IEquatable<ComputeKernel>
    {
        internal IntPtr Value;

        #region IComparable<ComputeKernel> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputeKernel"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeKernel"/> to compare with the current <see cref="ComputeKernel"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputeKernel other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputeKernel> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputeKernel"/> is equal to the current <see cref="ComputeKernel"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeKernel"/> to compare with the current <see cref="ComputeKernel"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeKernel"/> is equal to the current
        /// <see cref="ComputeKernel"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputeKernel other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputeKernel"/></summary>
        public static readonly ComputeKernel Zero = new ComputeKernel();

        /// <summary>Tests two <see cref="ComputeKernel"/> instances for equality.</summary>
        public static bool operator ==(ComputeKernel left, ComputeKernel right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputeKernel"/> instances for inequality.</summary>
        public static bool operator !=(ComputeKernel left, ComputeKernel right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputeKernel"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputeKernel"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeKernel"/> is equal to the current
        /// <see cref="ComputeKernel"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputeKernel && Equals((ComputeKernel)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputeKernel"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputeKernel usage.
    /// </summary>
    public static partial class ComputeKernelExtensions
    {
        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr[] param_value_size_ret)
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, ref param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T3>(this ComputeKernel kernel, OpenTK.Compute.CL10.KernelInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        
        {
            return CL.GetKernelInfo(kernel, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr[] param_value_size_ret)
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[] param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[,] param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[,,] param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[,,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T4[,,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T4 param_value, [OutAttribute] IntPtr[] param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T4 param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, ref param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T4>(this ComputeKernel kernel, ComputeDevice device, OpenTK.Compute.CL10.KernelWorkGroupInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T4 param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T4 : struct
        
        {
            return CL.GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        public static ErrorCode ReleaseKernel(this ComputeKernel kernel)
        {
            return CL.ReleaseKernel(kernel);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        public static ErrorCode RetainKernel(this ComputeKernel kernel)
        {
            return CL.RetainKernel(kernel);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        public static ErrorCode SetKernelArg(this ComputeKernel kernel, Int32 arg_index, IntPtr arg_size, IntPtr arg_value)
        {
            return CL.SetKernelArg(kernel, arg_index, arg_size, arg_value);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg<T3>(this ComputeKernel kernel, Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] T3[] arg_value)
            where T3 : struct
        
        {
            return CL.SetKernelArg(kernel, arg_index, arg_size, arg_value);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg<T3>(this ComputeKernel kernel, Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] T3[,] arg_value)
            where T3 : struct
        
        {
            return CL.SetKernelArg(kernel, arg_index, arg_size, arg_value);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg<T3>(this ComputeKernel kernel, Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] T3[,,] arg_value)
            where T3 : struct
        
        {
            return CL.SetKernelArg(kernel, arg_index, arg_size, arg_value);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="kernel"></param>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        public static ErrorCode SetKernelArg<T3>(this ComputeKernel kernel, Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] ref T3 arg_value)
            where T3 : struct
        
        {
            return CL.SetKernelArg(kernel, arg_index, arg_size, ref arg_value);
        }

    }

    /// <summary>
    /// Defines methods to simplify ComputeMemory usage.
    /// </summary>
    public partial struct ComputeMemory : IComparable<ComputeMemory>, IEquatable<ComputeMemory>
    {
        internal IntPtr Value;

        #region IComparable<ComputeMemory> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputeMemory"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeMemory"/> to compare with the current <see cref="ComputeMemory"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputeMemory other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputeMemory> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputeMemory"/> is equal to the current <see cref="ComputeMemory"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeMemory"/> to compare with the current <see cref="ComputeMemory"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeMemory"/> is equal to the current
        /// <see cref="ComputeMemory"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputeMemory other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputeMemory"/></summary>
        public static readonly ComputeMemory Zero = new ComputeMemory();

        /// <summary>Tests two <see cref="ComputeMemory"/> instances for equality.</summary>
        public static bool operator ==(ComputeMemory left, ComputeMemory right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputeMemory"/> instances for inequality.</summary>
        public static bool operator !=(ComputeMemory left, ComputeMemory right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputeMemory"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputeMemory"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeMemory"/> is equal to the current
        /// <see cref="ComputeMemory"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputeMemory && Equals((ComputeMemory)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputeMemory"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputeMemory usage.
    /// </summary>
    public static partial class ComputeMemoryExtensions
    {
        /// <summary>[requires: v1.0]</summary>
        /// <param name="memobj"></param>
        public static ErrorCode ReleaseMemObject(this ComputeMemory memobj)
        {
            return CL.ReleaseMemObject(memobj);
        }

    }

    /// <summary>
    /// Defines methods to simplify ComputePlatform usage.
    /// </summary>
    public partial struct ComputePlatform : IComparable<ComputePlatform>, IEquatable<ComputePlatform>
    {
        internal IntPtr Value;

        #region IComparable<ComputePlatform> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputePlatform"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputePlatform"/> to compare with the current <see cref="ComputePlatform"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputePlatform other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputePlatform> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputePlatform"/> is equal to the current <see cref="ComputePlatform"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputePlatform"/> to compare with the current <see cref="ComputePlatform"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputePlatform"/> is equal to the current
        /// <see cref="ComputePlatform"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputePlatform other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputePlatform"/></summary>
        public static readonly ComputePlatform Zero = new ComputePlatform();

        /// <summary>Tests two <see cref="ComputePlatform"/> instances for equality.</summary>
        public static bool operator ==(ComputePlatform left, ComputePlatform right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputePlatform"/> instances for inequality.</summary>
        public static bool operator !=(ComputePlatform left, ComputePlatform right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputePlatform"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputePlatform"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputePlatform"/> is equal to the current
        /// <see cref="ComputePlatform"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputePlatform && Equals((ComputePlatform)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputePlatform"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="num_entries"></param>
        /// <param name="platforms"></param>
        /// <param name="num_platforms"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetPlatformIDs(Int32 num_entries, ComputePlatform[] platforms, [OutAttribute] out Int32 num_platforms)
        {
            return CL.GetPlatformIDs(num_entries, platforms, out num_platforms);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="num_entries"></param>
        /// <param name="platforms"></param>
        /// <param name="num_platforms"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetPlatformIDs(Int32 num_entries, ref ComputePlatform platforms, [OutAttribute] out Int32 num_platforms)
        {
            return CL.GetPlatformIDs(num_entries, ref platforms, out num_platforms);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="num_entries"></param>
        /// <param name="platforms"></param>
        /// <param name="num_platforms"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetPlatformIDs(Int32 num_entries, ComputePlatform* platforms, [OutAttribute] Int32* num_platforms)
        {
            return CL.GetPlatformIDs(num_entries, platforms, num_platforms);
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputePlatform usage.
    /// </summary>
    public static partial class ComputePlatformExtensions
    {
    }

    /// <summary>
    /// Defines methods to simplify ComputeProgram usage.
    /// </summary>
    public partial struct ComputeProgram : IComparable<ComputeProgram>, IEquatable<ComputeProgram>
    {
        internal IntPtr Value;

        #region IComparable<ComputeProgram> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputeProgram"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeProgram"/> to compare with the current <see cref="ComputeProgram"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputeProgram other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputeProgram> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputeProgram"/> is equal to the current <see cref="ComputeProgram"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeProgram"/> to compare with the current <see cref="ComputeProgram"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeProgram"/> is equal to the current
        /// <see cref="ComputeProgram"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputeProgram other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputeProgram"/></summary>
        public static readonly ComputeProgram Zero = new ComputeProgram();

        /// <summary>Tests two <see cref="ComputeProgram"/> instances for equality.</summary>
        public static bool operator ==(ComputeProgram left, ComputeProgram right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputeProgram"/> instances for inequality.</summary>
        public static bool operator !=(ComputeProgram left, ComputeProgram right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputeProgram"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputeProgram"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeProgram"/> is equal to the current
        /// <see cref="ComputeProgram"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputeProgram && Equals((ComputeProgram)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputeProgram"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputeProgram usage.
    /// </summary>
    public static partial class ComputeProgramExtensions
    {
        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram(this ComputeProgram program, Int32 num_devices, ComputeDevice[] device_list, String options, ProgramNotifyDelegate pfn_notify, IntPtr user_data)
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice[] device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice[] device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[,] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice[] device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[,,] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice[] device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] ref T5 user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, ref user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram(this ComputeProgram program, Int32 num_devices, ref ComputeDevice device_list, String options, ProgramNotifyDelegate pfn_notify, IntPtr user_data)
        {
            return CL.BuildProgram(program, num_devices, ref device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ref ComputeDevice device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, ref device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ref ComputeDevice device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[,] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, ref device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ref ComputeDevice device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[,,] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, ref device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ref ComputeDevice device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] ref T5 user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, ref device_list, options, pfn_notify, ref user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode BuildProgram(this ComputeProgram program, Int32 num_devices, ComputeDevice* device_list, String options, ProgramNotifyDelegate pfn_notify, IntPtr user_data)
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice* device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice* device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[,] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice* device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T5[,,] user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode BuildProgram<T5>(this ComputeProgram program, Int32 num_devices, ComputeDevice* device_list, String options, ProgramNotifyDelegate pfn_notify, [InAttribute, OutAttribute] ref T5 user_data)
            where T5 : struct
        
        {
            return CL.BuildProgram(program, num_devices, device_list, options, pfn_notify, ref user_data);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="kernel_name"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeKernel CreateKernel(this ComputeProgram program, String kernel_name, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateKernel(program, kernel_name, out errcode_ret);
        }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="program"></param>
        /// <param name="kernel_name"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeKernel CreateKernel(this ComputeProgram program, String kernel_name, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateKernel(program, kernel_name, errcode_ret);
        }

    }

    /// <summary>
    /// Defines methods to simplify ComputeSampler usage.
    /// </summary>
    public partial struct ComputeSampler : IComparable<ComputeSampler>, IEquatable<ComputeSampler>
    {
        internal IntPtr Value;

        #region IComparable<ComputeSampler> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ComputeSampler"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeSampler"/> to compare with the current <see cref="ComputeSampler"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ComputeSampler other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ComputeSampler> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ComputeSampler"/> is equal to the current <see cref="ComputeSampler"/>.
        /// </summary>
        /// <param name="other">The <see cref="ComputeSampler"/> to compare with the current <see cref="ComputeSampler"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeSampler"/> is equal to the current
        /// <see cref="ComputeSampler"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ComputeSampler other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ComputeSampler"/></summary>
        public static readonly ComputeSampler Zero = new ComputeSampler();

        /// <summary>Tests two <see cref="ComputeSampler"/> instances for equality.</summary>
        public static bool operator ==(ComputeSampler left, ComputeSampler right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ComputeSampler"/> instances for inequality.</summary>
        public static bool operator !=(ComputeSampler left, ComputeSampler right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ComputeSampler"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ComputeSampler"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ComputeSampler"/> is equal to the current
        /// <see cref="ComputeSampler"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ComputeSampler && Equals((ComputeSampler)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ComputeSampler"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ComputeSampler usage.
    /// </summary>
    public static partial class ComputeSamplerExtensions
    {
    }

    /// <summary>
    /// Defines methods to simplify ContextProperty usage.
    /// </summary>
    public partial struct ContextProperty : IComparable<ContextProperty>, IEquatable<ContextProperty>
    {
        IntPtr Property;
        IntPtr Value;

        #region IComparable<ContextProperty> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="ContextProperty"/>.
        /// </summary>
        /// <param name="other">The <see cref="ContextProperty"/> to compare with the current <see cref="ContextProperty"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(ContextProperty other)
        {
            int result = 0;
            if (result == 0)
                result = Property.CompareTo(other.Property);
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<ContextProperty> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="ContextProperty"/> is equal to the current <see cref="ContextProperty"/>.
        /// </summary>
        /// <param name="other">The <see cref="ContextProperty"/> to compare with the current <see cref="ContextProperty"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ContextProperty"/> is equal to the current
        /// <see cref="ContextProperty"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(ContextProperty other)
        {
            bool result = true;
            result &= Property.Equals(other.Property);
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="ContextProperty"/></summary>
        public static readonly ContextProperty Zero = new ContextProperty();

        /// <summary>Tests two <see cref="ContextProperty"/> instances for equality.</summary>
        public static bool operator ==(ContextProperty left, ContextProperty right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="ContextProperty"/> instances for inequality.</summary>
        public static bool operator !=(ContextProperty left, ContextProperty right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="ContextProperty"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="ContextProperty"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="ContextProperty"/> is equal to the current
        /// <see cref="ContextProperty"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is ContextProperty && Equals((ContextProperty)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="ContextProperty"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Property.GetHashCode();
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify ContextProperty usage.
    /// </summary>
    public static partial class ContextPropertyExtensions
    {
    }
}
