// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
 index);

        GamePadCapabilities GetCapabilities(int index);

        /// <summary>
        /// Retrieves the device name for the gamepad device.
        /// </summary>
        /// <param name="index">The index of the gamepad device.</param>
        /// <returns>A <see cref="System.String"/> with the name of the specified device or <see cref="System.String.Empty"/>.</returns>
        /// <remarks>
        /// <para>If no device exists at the specified index, the return value is <see cref="System.String.Empty"/>.</para></remarks>
        string GetName(int index);

        bool SetVibration(int index, float left, float right);
    }
}
