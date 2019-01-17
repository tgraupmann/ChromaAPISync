#region Public API Methods
	/*
		Adds a frame to the `Chroma` animation and sets the `duration` (in seconds). 
		The `color` is expected to be an array of the dimensions for the `deviceType/device`. 
		The `length` parameter is the size of the `color` array. For `EChromaSDKDevice1DEnum` 
		the array size should be `MAX LEDS`. For `EChromaSDKDevice2DEnum` the array 
		size should be `MAX ROW` * `MAX COLUMN`. Returns the animation id upon 
		success. Returns -1 upon failure.
	*/
	public static int AddFrame(int animationId, float duration, int[] colors, int length)
	{
		int result = PluginAddFrame(animationId, duration, colors, length);
		return result;
	}
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by id.
	*/
	public static void AddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginAddNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by name.
	*/
	public static void AddNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginAddNonZeroAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginAddNonZeroAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		id.
	*/
	public static void AddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginAddNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
	}
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		name.
	*/
	public static void AddNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginAddNonZeroAllKeysAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginAddNonZeroAllKeysAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by id.
	*/
	public static void AddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginAddNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
	}
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by name.
	*/
	public static void AddNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginAddNonZeroAllKeysOffsetName(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginAddNonZeroAllKeysOffsetNameD(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by id.
	*/
	public static void AddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginAddNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by name.
	*/
	public static void AddNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginAddNonZeroTargetAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginAddNonZeroTargetAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by id.
	*/
	public static void AddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginAddNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
	}
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by name.
	*/
	public static void AddNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginAddNonZeroTargetAllKeysAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by id.
	*/
	public static void AddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginAddNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
	}
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by name.
	*/
	public static void AddNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginAddNonZeroTargetAllKeysOffsetName(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginAddNonZeroTargetAllKeysOffsetNameD(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Append all source frames to the target animation, reference source and target 
		by id.
	*/
	public static void AppendAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginAppendAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Append all source frames to the target animation, reference source and target 
		by name.
	*/
	public static void AppendAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginAppendAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AppendAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginAppendAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		`PluginClearAll` will issue a `CLEAR` effect for all devices.
	*/
	public static void ClearAll()
	{
		PluginClearAll();
	}
	/*
		`PluginClearAnimationType` will issue a `CLEAR` effect for the given device.
	*/
	public static void ClearAnimationType(int deviceType, int device)
	{
		PluginClearAnimationType(deviceType, device);
	}
	/*
		`PluginCloseAll` closes all open animations so they can be reloaded from 
		disk. The set of animations will be stopped if playing.
	*/
	public static void CloseAll()
	{
		PluginCloseAll();
	}
	/*
		Closes the `Chroma` animation to free up resources referenced by id. Returns 
		the animation id upon success. Returns -1 upon failure. This might be used 
		while authoring effects if there was a change necessitating re-opening 
		the animation. The animation id can no longer be used once closed.
	*/
	public static int CloseAnimation(int animationId)
	{
		int result = PluginCloseAnimation(animationId);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double CloseAnimationD(double animationId)
	{
		double result = PluginCloseAnimationD(animationId);
		return result;
	}
	/*
		Closes the `Chroma` animation referenced by name so that the animation can 
		be reloaded from disk.
	*/
	public static void CloseAnimationName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginCloseAnimationName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CloseAnimationNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginCloseAnimationNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		`PluginCloseComposite` closes a set of animations so they can be reloaded 
		from disk. The set of animations will be stopped if playing.
	*/
	public static void CloseComposite(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		PluginCloseComposite(lpName);
		FreeIntPtr(lpName);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CloseCompositeD(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		double result = PluginCloseCompositeD(lpName);
		FreeIntPtr(lpName);
		return result;
	}
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by id.
	*/
	public static int CopyAnimation(int sourceAnimationId, string targetAnimation)
	{
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		int result = PluginCopyAnimation(sourceAnimationId, lpTargetAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by name.
	*/
	public static void CopyAnimationName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyAnimationName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyAnimationNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyAnimationNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
	*/
	public static void CopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity)
	{
		PluginCopyBlueChannelAllFrames(animationId, redIntensity, greenIntensity);
	}
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by name.
	*/
	public static void CopyBlueChannelAllFramesName(string path, float redIntensity, float greenIntensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginCopyBlueChannelAllFramesName(lpPath, redIntensity, greenIntensity);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyBlueChannelAllFramesNameD(string path, double redIntensity, double greenIntensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginCopyBlueChannelAllFramesNameD(lpPath, redIntensity, greenIntensity);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by id.
	*/
	public static void CopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity)
	{
		PluginCopyGreenChannelAllFrames(animationId, redIntensity, blueIntensity);
	}
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
	*/
	public static void CopyGreenChannelAllFramesName(string path, float redIntensity, float blueIntensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginCopyGreenChannelAllFramesName(lpPath, redIntensity, blueIntensity);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyGreenChannelAllFramesNameD(string path, double redIntensity, double blueIntensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginCopyGreenChannelAllFramesNameD(lpPath, redIntensity, blueIntensity);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame. Reference the source and target by id.
	*/
	public static void CopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
	{
		PluginCopyKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by id.
	*/
	public static void CopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey)
	{
		PluginCopyKeyColorAllFrames(sourceAnimationId, targetAnimationId, rzkey);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by name.
	*/
	public static void CopyKeyColorAllFramesName(string sourceAnimation, string targetAnimation, int rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyKeyColorAllFramesName(lpSourceAnimation, lpTargetAnimation, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyKeyColorAllFramesNameD(string sourceAnimation, string targetAnimation, double rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyKeyColorAllFramesNameD(lpSourceAnimation, lpTargetAnimation, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by id.
	*/
	public static void CopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset)
	{
		PluginCopyKeyColorAllFramesOffset(sourceAnimationId, targetAnimationId, rzkey, offset);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by name.
	*/
	public static void CopyKeyColorAllFramesOffsetName(string sourceAnimation, string targetAnimation, int rzkey, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyKeyColorAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, rzkey, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyKeyColorAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double rzkey, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyKeyColorAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, rzkey, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame.
	*/
	public static void CopyKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyKeyColorName(lpSourceAnimation, lpTargetAnimation, frameId, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyKeyColorNameD(lpSourceAnimation, lpTargetAnimation, frameId, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy source animation to target animation for the given frame. Source and 
		target are referenced by id.
	*/
	public static void CopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
	{
		PluginCopyNonZeroAllKeys(sourceAnimationId, targetAnimationId, frameId);
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by id.
	*/
	public static void CopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by name.
	*/
	public static void CopyNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by id.
	*/
	public static void CopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginCopyNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by name.
	*/
	public static void CopyNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroAllKeysAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroAllKeysAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero colors from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
	*/
	public static void CopyNonZeroAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroAllKeysName(lpSourceAnimation, lpTargetAnimation, frameId);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysNameD(string sourceAnimation, string targetAnimation, double frameId)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroAllKeysNameD(lpSourceAnimation, lpTargetAnimation, frameId);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by id.
	*/
	public static void CopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginCopyNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
	}
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by name.
	*/
	public static void CopyNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroAllKeysOffsetName(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroAllKeysOffsetNameD(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
	*/
	public static void CopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
	{
		PluginCopyNonZeroKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
	*/
	public static void CopyNonZeroKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroKeyColorName(lpSourceAnimation, lpTargetAnimation, frameId, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroKeyColorNameD(lpSourceAnimation, lpTargetAnimation, frameId, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. Source and target 
		are referenced by id.
	*/
	public static void CopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
	{
		PluginCopyNonZeroTargetAllKeys(sourceAnimationId, targetAnimationId, frameId);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by id.
	*/
	public static void CopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
	*/
	public static void CopyNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroTargetAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroTargetAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
	*/
	public static void CopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginCopyNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames starting at the target offset 
		for the length of the source animation. Source and target animations are 
		referenced by name.
	*/
	public static void CopyNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. The source and target 
		are referenced by name.
	*/
	public static void CopyNonZeroTargetAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroTargetAllKeysName(lpSourceAnimation, lpTargetAnimation, frameId);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysNameD(string sourceAnimation, string targetAnimation, double frameId)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroTargetAllKeysNameD(lpSourceAnimation, lpTargetAnimation, frameId);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by id.
	*/
	public static void CopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginCopyNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by name.
	*/
	public static void CopyNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyNonZeroTargetAllKeysOffsetName(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyNonZeroTargetAllKeysOffsetNameD(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy red channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
	*/
	public static void CopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity)
	{
		PluginCopyRedChannelAllFrames(animationId, greenIntensity, blueIntensity);
	}
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
	*/
	public static void CopyRedChannelAllFramesName(string path, float greenIntensity, float blueIntensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginCopyRedChannelAllFramesName(lpPath, greenIntensity, blueIntensity);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyRedChannelAllFramesNameD(string path, double greenIntensity, double blueIntensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginCopyRedChannelAllFramesNameD(lpPath, greenIntensity, blueIntensity);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by id.
	*/
	public static void CopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by name.
	*/
	public static void CopyZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyZeroAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyZeroAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by id.
	*/
	public static void CopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginCopyZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
	}
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by name.
	*/
	public static void CopyZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyZeroAllKeysAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyZeroAllKeysAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
	*/
	public static void CopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
	{
		PluginCopyZeroKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey);
	}
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by name.
	*/
	public static void CopyZeroKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyZeroKeyColorName(lpSourceAnimation, lpTargetAnimation, frameId, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyZeroKeyColorNameD(lpSourceAnimation, lpTargetAnimation, frameId, rzkey);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by id.
	*/
	public static void CopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by name.
	*/
	public static void CopyZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginCopyZeroTargetAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginCopyZeroTargetAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateChromaLinkEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		int result = PluginCoreCreateChromaLinkEffect(Effect, pParam, pEffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateEffect(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		int result = PluginCoreCreateEffect(DeviceId, Effect, pParam, pEffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateHeadsetEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		int result = PluginCoreCreateHeadsetEffect(Effect, pParam, pEffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateKeyboardEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		int result = PluginCoreCreateKeyboardEffect(Effect, pParam, pEffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateKeypadEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		int result = PluginCoreCreateKeypadEffect(Effect, pParam, pEffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateMouseEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		int result = PluginCoreCreateMouseEffect(Effect, pParam, pEffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateMousepadEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		int result = PluginCoreCreateMousepadEffect(Effect, pParam, pEffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreDeleteEffect(RZEFFECTID EffectId)
	{
		int result = PluginCoreDeleteEffect(EffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreInit()
	{
		int result = PluginCoreInit();
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreQueryDevice(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE& DeviceInfo)
	{
		int result = PluginCoreQueryDevice(DeviceId, DeviceInfo);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreSetEffect(RZEFFECTID EffectId)
	{
		int result = PluginCoreSetEffect(EffectId);
		return result;
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreUnInit()
	{
		int result = PluginCoreUnInit();
		return result;
	}
	/*
		Creates a `Chroma` animation at the given path. The `deviceType` parameter 
		uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter uses 
		`EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, respective 
		to the `deviceType`. Returns the animation id upon success. Returns -1 
		upon failure. Saves a `Chroma` animation file with the `.chroma` extension 
		at the given path. Returns the animation id upon success. Returns -1 upon 
		failure.
	*/
	public static int CreateAnimation(string path, int deviceType, int device)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginCreateAnimation(lpPath, deviceType, device);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Creates a `Chroma` animation in memory without creating a file. The `deviceType` 
		parameter uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter 
		uses `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, 
		respective to the `deviceType`. Returns the animation id upon success. 
		Returns -1 upon failure. Returns the animation id upon success. Returns 
		-1 upon failure.
	*/
	public static int CreateAnimationInMemory(int deviceType, int device)
	{
		int result = PluginCreateAnimationInMemory(deviceType, device);
		return result;
	}
	/*
		Create a device specific effect.
	*/
	public static int CreateEffect(RZDEVICEID deviceId, ChromaSDK::EFFECT_TYPE effect, int[] colors, int size, ChromaSDK::FChromaSDKGuid* effectId)
	{
		int result = PluginCreateEffect(deviceId, effect, colors, size, effectId);
		return result;
	}
	/*
		Delete an effect given the effect id.
	*/
	public static int DeleteEffect(System.Guid effectId)
	{
		int result = PluginDeleteEffect(effectId);
		return result;
	}
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by id.
	*/
	public static void DuplicateFirstFrame(int animationId, int frameCount)
	{
		PluginDuplicateFirstFrame(animationId, frameCount);
	}
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by name.
	*/
	public static void DuplicateFirstFrameName(string path, int frameCount)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginDuplicateFirstFrameName(lpPath, frameCount);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double DuplicateFirstFrameNameD(string path, double frameCount)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginDuplicateFirstFrameNameD(lpPath, frameCount);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Duplicate all the frames of the animation to double the animation length. 
		Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		The animation is referenced by id.
	*/
	public static void DuplicateFrames(int animationId)
	{
		PluginDuplicateFrames(animationId);
	}
	/*
		Duplicate all the frames of the animation to double the animation length. 
		Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		The animation is referenced by name.
	*/
	public static void DuplicateFramesName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginDuplicateFramesName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double DuplicateFramesNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginDuplicateFramesNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Duplicate all the animation frames in reverse so that the animation plays 
		forwards and backwards. Animation is referenced by id.
	*/
	public static void DuplicateMirrorFrames(int animationId)
	{
		PluginDuplicateMirrorFrames(animationId);
	}
	/*
		Duplicate all the animation frames in reverse so that the animation plays 
		forwards and backwards. Animation is referenced by name.
	*/
	public static void DuplicateMirrorFramesName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginDuplicateMirrorFramesName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double DuplicateMirrorFramesNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginDuplicateMirrorFramesNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by id.
	*/
	public static void FadeEndFrames(int animationId, int fade)
	{
		PluginFadeEndFrames(animationId, fade);
	}
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by name.
	*/
	public static void FadeEndFramesName(string path, int fade)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFadeEndFramesName(lpPath, fade);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FadeEndFramesNameD(string path, double fade)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFadeEndFramesNameD(lpPath, fade);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by id.
	*/
	public static void FadeStartFrames(int animationId, int fade)
	{
		PluginFadeStartFrames(animationId, fade);
	}
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by name.
	*/
	public static void FadeStartFramesName(string path, int fade)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFadeStartFramesName(lpPath, fade);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FadeStartFramesNameD(string path, double fade)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFadeStartFramesNameD(lpPath, fade);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
	*/
	public static void FillColor(int animationId, int frameId, int color)
	{
		PluginFillColor(animationId, frameId, color);
	}
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by id.
	*/
	public static void FillColorAllFrames(int animationId, int color)
	{
		PluginFillColorAllFrames(animationId, color);
	}
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by name.
	*/
	public static void FillColorAllFramesName(string path, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillColorAllFramesName(lpPath, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorAllFramesNameD(string path, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillColorAllFramesNameD(lpPath, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by id.
	*/
	public static void FillColorAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginFillColorAllFramesRGB(animationId, red, green, blue);
	}
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by name.
	*/
	public static void FillColorAllFramesRGBName(string path, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillColorAllFramesRGBName(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillColorAllFramesRGBNameD(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
	*/
	public static void FillColorName(string path, int frameId, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillColorName(lpPath, frameId, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorNameD(string path, double frameId, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillColorNameD(lpPath, frameId, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
	*/
	public static void FillColorRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginFillColorRGB(animationId, frameId, red, green, blue);
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
	*/
	public static void FillColorRGBName(string path, int frameId, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillColorRGBName(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillColorRGBNameD(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by id.
	*/
	public static void FillNonZeroColor(int animationId, int frameId, int color)
	{
		PluginFillNonZeroColor(animationId, frameId, color);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by id.
	*/
	public static void FillNonZeroColorAllFrames(int animationId, int color)
	{
		PluginFillNonZeroColorAllFrames(animationId, color);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by name.
	*/
	public static void FillNonZeroColorAllFramesName(string path, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillNonZeroColorAllFramesName(lpPath, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorAllFramesNameD(string path, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillNonZeroColorAllFramesNameD(lpPath, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
	*/
	public static void FillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginFillNonZeroColorAllFramesRGB(animationId, red, green, blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
	*/
	public static void FillNonZeroColorAllFramesRGBName(string path, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillNonZeroColorAllFramesRGBName(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillNonZeroColorAllFramesRGBNameD(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by name.
	*/
	public static void FillNonZeroColorName(string path, int frameId, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillNonZeroColorName(lpPath, frameId, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorNameD(string path, double frameId, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillNonZeroColorNameD(lpPath, frameId, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
	*/
	public static void FillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginFillNonZeroColorRGB(animationId, frameId, red, green, blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
	*/
	public static void FillNonZeroColorRGBName(string path, int frameId, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillNonZeroColorRGBName(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillNonZeroColorRGBNameD(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by id.
	*/
	public static void FillRandomColors(int animationId, int frameId)
	{
		PluginFillRandomColors(animationId, frameId);
	}
	/*
		Fill the frame with random RGB values for all frames. Animation is referenced 
		by id.
	*/
	public static void FillRandomColorsAllFrames(int animationId)
	{
		PluginFillRandomColorsAllFrames(animationId);
	}
	/*
		Fill the frame with random RGB values for all frames. Animation is referenced 
		by name.
	*/
	public static void FillRandomColorsAllFramesName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillRandomColorsAllFramesName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsAllFramesNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillRandomColorsAllFramesNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by id.
	*/
	public static void FillRandomColorsBlackAndWhite(int animationId, int frameId)
	{
		PluginFillRandomColorsBlackAndWhite(animationId, frameId);
	}
	/*
		Fill the frame with random black and white values for all frames. Animation 
		is referenced by id.
	*/
	public static void FillRandomColorsBlackAndWhiteAllFrames(int animationId)
	{
		PluginFillRandomColorsBlackAndWhiteAllFrames(animationId);
	}
	/*
		Fill the frame with random black and white values for all frames. Animation 
		is referenced by name.
	*/
	public static void FillRandomColorsBlackAndWhiteAllFramesName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillRandomColorsBlackAndWhiteAllFramesName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsBlackAndWhiteAllFramesNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillRandomColorsBlackAndWhiteAllFramesNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by name.
	*/
	public static void FillRandomColorsBlackAndWhiteName(string path, int frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillRandomColorsBlackAndWhiteName(lpPath, frameId);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsBlackAndWhiteNameD(string path, double frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillRandomColorsBlackAndWhiteNameD(lpPath, frameId);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by name.
	*/
	public static void FillRandomColorsName(string path, int frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillRandomColorsName(lpPath, frameId);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsNameD(string path, double frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillRandomColorsNameD(lpPath, frameId);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColors(int animationId, int frameId, int threshold, int color)
	{
		PluginFillThresholdColors(animationId, frameId, threshold, color);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsAllFrames(int animationId, int threshold, int color)
	{
		PluginFillThresholdColorsAllFrames(animationId, threshold, color);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsAllFramesName(string path, int threshold, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdColorsAllFramesName(lpPath, threshold, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsAllFramesNameD(string path, double threshold, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdColorsAllFramesNameD(lpPath, threshold, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue)
	{
		PluginFillThresholdColorsAllFramesRGB(animationId, threshold, red, green, blue);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsAllFramesRGBName(string path, int threshold, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdColorsAllFramesRGBName(lpPath, threshold, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsAllFramesRGBNameD(string path, double threshold, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdColorsAllFramesRGBNameD(lpPath, threshold, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		PluginFillThresholdColorsMinMaxAllFramesRGB(animationId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
	}
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsMinMaxAllFramesRGBName(string path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdColorsMinMaxAllFramesRGBName(lpPath, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsMinMaxAllFramesRGBNameD(string path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdColorsMinMaxAllFramesRGBNameD(lpPath, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		PluginFillThresholdColorsMinMaxRGB(animationId, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
	}
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsMinMaxRGBName(string path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdColorsMinMaxRGBName(lpPath, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsMinMaxRGBNameD(string path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdColorsMinMaxRGBNameD(lpPath, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsName(string path, int frameId, int threshold, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdColorsName(lpPath, frameId, threshold, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsNameD(string path, double frameId, double threshold, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdColorsNameD(lpPath, frameId, threshold, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue)
	{
		PluginFillThresholdColorsRGB(animationId, frameId, threshold, red, green, blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsRGBName(string path, int frameId, int threshold, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdColorsRGBName(lpPath, frameId, threshold, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsRGBNameD(string path, double frameId, double threshold, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdColorsRGBNameD(lpPath, frameId, threshold, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		PluginFillThresholdRGBColorsAllFramesRGB(animationId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdRGBColorsAllFramesRGBName(string path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdRGBColorsAllFramesRGBName(lpPath, redThreshold, greenThreshold, blueThreshold, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdRGBColorsAllFramesRGBNameD(string path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdRGBColorsAllFramesRGBNameD(lpPath, redThreshold, greenThreshold, blueThreshold, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		PluginFillThresholdRGBColorsRGB(animationId, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdRGBColorsRGBName(string path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillThresholdRGBColorsRGBName(lpPath, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdRGBColorsRGBNameD(string path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillThresholdRGBColorsRGBNameD(lpPath, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
	*/
	public static void FillZeroColor(int animationId, int frameId, int color)
	{
		PluginFillZeroColor(animationId, frameId, color);
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
	*/
	public static void FillZeroColorAllFrames(int animationId, int color)
	{
		PluginFillZeroColorAllFrames(animationId, color);
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
	*/
	public static void FillZeroColorAllFramesName(string path, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillZeroColorAllFramesName(lpPath, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorAllFramesNameD(string path, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillZeroColorAllFramesNameD(lpPath, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
	*/
	public static void FillZeroColorAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginFillZeroColorAllFramesRGB(animationId, red, green, blue);
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
	*/
	public static void FillZeroColorAllFramesRGBName(string path, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillZeroColorAllFramesRGBName(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillZeroColorAllFramesRGBNameD(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
	*/
	public static void FillZeroColorName(string path, int frameId, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillZeroColorName(lpPath, frameId, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorNameD(string path, double frameId, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillZeroColorNameD(lpPath, frameId, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
	*/
	public static void FillZeroColorRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginFillZeroColorRGB(animationId, frameId, red, green, blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
	*/
	public static void FillZeroColorRGBName(string path, int frameId, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginFillZeroColorRGBName(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginFillZeroColorRGBNameD(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by id.
	*/
	public static int Get1DColor(int animationId, int frameId, int led)
	{
		int result = PluginGet1DColor(animationId, frameId, led);
		return result;
	}
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by name.
	*/
	public static int Get1DColorName(string path, int frameId, int led)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginGet1DColorName(lpPath, frameId, led);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double Get1DColorNameD(string path, double frameId, double led)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginGet1DColorNameD(lpPath, frameId, led);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by id.
	*/
	public static int Get2DColor(int animationId, int frameId, int row, int column)
	{
		int result = PluginGet2DColor(animationId, frameId, row, column);
		return result;
	}
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by name.
	*/
	public static int Get2DColorName(string path, int frameId, int row, int column)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginGet2DColorName(lpPath, frameId, row, column);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double Get2DColorNameD(string path, double frameId, double row, double column)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginGet2DColorNameD(lpPath, frameId, row, column);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Get the animation id for the named animation.
	*/
	public static int GetAnimation(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		int result = PluginGetAnimation(lpName);
		FreeIntPtr(lpName);
		return result;
	}
	/*
		`PluginGetAnimationCount` will return the number of loaded animations.
	*/
	public static int GetAnimationCount()
	{
		int result = PluginGetAnimationCount();
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetAnimationD(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		double result = PluginGetAnimationD(lpName);
		FreeIntPtr(lpName);
		return result;
	}
	/*
		`PluginGetAnimationId` will return the `animationId` given the `index` of 
		the loaded animation. The `index` is zero-based and less than the number 
		returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		get the name of the animation.
	*/
	public static int GetAnimationId(int index)
	{
		int result = PluginGetAnimationId(index);
		return result;
	}
	/*
		`PluginGetAnimationName` takes an `animationId` and returns the name of 
		the animation of the `.chroma` animation file. If a name is not available 
		then an empty string will be returned.
	*/
	public static string GetAnimationName(int animationId)
	{
		string result = PluginGetAnimationName(animationId);
		return result;
	}
	/*
		Get the current frame of the animation referenced by id.
	*/
	public static int GetCurrentFrame(int animationId)
	{
		int result = PluginGetCurrentFrame(animationId);
		return result;
	}
	/*
		Get the current frame of the animation referenced by name.
	*/
	public static int GetCurrentFrameName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginGetCurrentFrameName(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetCurrentFrameNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginGetCurrentFrameNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
	*/
	public static int GetDevice(int animationId)
	{
		int result = PluginGetDevice(animationId);
		return result;
	}
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
	*/
	public static int GetDeviceName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginGetDeviceName(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetDeviceNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginGetDeviceNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetDeviceType(int animationId)
	{
		int result = PluginGetDeviceType(animationId);
		return result;
	}
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetDeviceTypeName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginGetDeviceTypeName(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetDeviceTypeNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginGetDeviceTypeNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Gets the frame colors and duration (in seconds) for a `Chroma` animation. 
		The `color` is expected to be an array of the expected dimensions for the 
		`deviceType/device`. The `length` parameter is the size of the `color` 
		array. For `EChromaSDKDevice1DEnum` the array size should be `MAX LEDS`. 
		For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` * `MAX 
		COLUMN`. Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int GetFrame(int animationId, int frameIndex, float* duration, int[] colors, int length)
	{
		int result = PluginGetFrame(animationId, frameIndex, duration, colors, length);
		return result;
	}
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
	*/
	public static int GetFrameCount(int animationId)
	{
		int result = PluginGetFrameCount(animationId);
		return result;
	}
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
	*/
	public static int GetFrameCountName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginGetFrameCountName(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetFrameCountNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginGetFrameCountNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Get the color of an animation key for the given frame referenced by id.
	*/
	public static int GetKeyColor(int animationId, int frameId, int rzkey)
	{
		int result = PluginGetKeyColor(animationId, frameId, rzkey);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetKeyColorD(string path, double frameId, double rzkey)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginGetKeyColorD(lpPath, frameId, rzkey);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Get the color of an animation key for the given frame referenced by name.
	*/
	public static int GetKeyColorName(string path, int frameId, int rzkey)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginGetKeyColorName(lpPath, frameId, rzkey);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		integer upon success. Returns -1 upon failure.
	*/
	public static int GetMaxColumn(int device)
	{
		int result = PluginGetMaxColumn(device);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetMaxColumnD(double device)
	{
		double result = PluginGetMaxColumnD(device);
		return result;
	}
	/*
		Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetMaxLeds(int device)
	{
		int result = PluginGetMaxLeds(device);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetMaxLedsD(double device)
	{
		double result = PluginGetMaxLedsD(device);
		return result;
	}
	/*
		Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetMaxRow(int device)
	{
		int result = PluginGetMaxRow(device);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetMaxRowD(double device)
	{
		double result = PluginGetMaxRowD(device);
		return result;
	}
	/*
		`PluginGetPlayingAnimationCount` will return the number of playing animations.
	*/
	public static int GetPlayingAnimationCount()
	{
		int result = PluginGetPlayingAnimationCount();
		return result;
	}
	/*
		`PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		of the playing animation. The `index` is zero-based and less than the number 
		returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		to get the name of the animation.
	*/
	public static int GetPlayingAnimationId(int index)
	{
		int result = PluginGetPlayingAnimationId(index);
		return result;
	}
	/*
		Get the RGB color given red, green, and blue.
	*/
	public static int GetRGB(int red, int green, int blue)
	{
		int result = PluginGetRGB(red, green, blue);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetRGBD(double red, double green, double blue)
	{
		double result = PluginGetRGBD(red, green, blue);
		return result;
	}
	/*
		Check if the animation has loop enabled referenced by id.
	*/
	public static bool HasAnimationLoop(int animationId)
	{
		bool result = PluginHasAnimationLoop(animationId);
		return result;
	}
	/*
		Check if the animation has loop enabled referenced by name.
	*/
	public static bool HasAnimationLoopName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		bool result = PluginHasAnimationLoopName(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double HasAnimationLoopNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginHasAnimationLoopNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		API methods auto initialize the ChromaSDK if not already initialized.
	*/
	public static int Init()
	{
		int result = PluginInit();
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double InitD()
	{
		double result = PluginInitD();
		return result;
	}
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by id.
	*/
	public static void InsertDelay(int animationId, int frameId, int delay)
	{
		PluginInsertDelay(animationId, frameId, delay);
	}
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by name.
	*/
	public static void InsertDelayName(string path, int frameId, int delay)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginInsertDelayName(lpPath, frameId, delay);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InsertDelayNameD(string path, double frameId, double delay)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginInsertDelayNameD(lpPath, frameId, delay);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by id.
	*/
	public static void InsertFrame(int animationId, int sourceFrame, int targetFrame)
	{
		PluginInsertFrame(animationId, sourceFrame, targetFrame);
	}
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by name.
	*/
	public static void InsertFrameName(string path, int sourceFrame, int targetFrame)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginInsertFrameName(lpPath, sourceFrame, targetFrame);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InsertFrameNameD(string path, double sourceFrame, double targetFrame)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginInsertFrameNameD(lpPath, sourceFrame, targetFrame);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		id.
	*/
	public static void InvertColors(int animationId, int frameId)
	{
		PluginInvertColors(animationId, frameId);
	}
	/*
		Invert all the colors for all frames. Animation is referenced by id.
	*/
	public static void InvertColorsAllFrames(int animationId)
	{
		PluginInvertColorsAllFrames(animationId);
	}
	/*
		Invert all the colors for all frames. Animation is referenced by name.
	*/
	public static void InvertColorsAllFramesName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginInvertColorsAllFramesName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InvertColorsAllFramesNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginInvertColorsAllFramesNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		name.
	*/
	public static void InvertColorsName(string path, int frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginInvertColorsName(lpPath, frameId);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InvertColorsNameD(string path, double frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginInvertColorsNameD(lpPath, frameId);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Check if the animation is paused referenced by id.
	*/
	public static bool IsAnimationPaused(int animationId)
	{
		bool result = PluginIsAnimationPaused(animationId);
		return result;
	}
	/*
		Check if the animation is paused referenced by name.
	*/
	public static bool IsAnimationPausedName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		bool result = PluginIsAnimationPausedName(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsAnimationPausedNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginIsAnimationPausedNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		The editor dialog is a non-blocking modal window, this method returns true 
		if the modal window is open, otherwise false.
	*/
	public static bool IsDialogOpen()
	{
		bool result = PluginIsDialogOpen();
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsDialogOpenD()
	{
		double result = PluginIsDialogOpenD();
		return result;
	}
	/*
		Returns true if the plugin has been initialized. Returns false if the plugin 
		is uninitialized.
	*/
	public static bool IsInitialized()
	{
		bool result = PluginIsInitialized();
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsInitializedD()
	{
		double result = PluginIsInitializedD();
		return result;
	}
	/*
		If the method can be invoked the method returns true.
	*/
	public static bool IsPlatformSupported()
	{
		bool result = PluginIsPlatformSupported();
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlatformSupportedD()
	{
		double result = PluginIsPlatformSupportedD();
		return result;
	}
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by id.
	*/
	public static bool IsPlaying(int animationId)
	{
		bool result = PluginIsPlaying(animationId);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlayingD(double animationId)
	{
		double result = PluginIsPlayingD(animationId);
		return result;
	}
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by name.
	*/
	public static bool IsPlayingName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		bool result = PluginIsPlayingName(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlayingNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginIsPlayingNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		`PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		the method will return true, otherwise false.
	*/
	public static bool IsPlayingType(int deviceType, int device)
	{
		bool result = PluginIsPlayingType(deviceType, device);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlayingTypeD(double deviceType, double device)
	{
		double result = PluginIsPlayingTypeD(deviceType, device);
		return result;
	}
	/*
		Do a lerp math operation on a float.
	*/
	public static float Lerp(float start, float end, float amt)
	{
		float result = PluginLerp(start, end, amt);
		return result;
	}
	/*
		Lerp from one color to another given t in the range 0.0 to 1.0.
	*/
	public static int LerpColor(int from, int to, float t)
	{
		int result = PluginLerpColor(from, to, t);
		return result;
	}
	/*
		Loads `Chroma` effects so that the animation can be played immediately. 
		Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int LoadAnimation(int animationId)
	{
		int result = PluginLoadAnimation(animationId);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double LoadAnimationD(double animationId)
	{
		double result = PluginLoadAnimationD(animationId);
		return result;
	}
	/*
		Load the named animation.
	*/
	public static void LoadAnimationName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginLoadAnimationName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		Load a composite set of animations.
	*/
	public static void LoadComposite(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		PluginLoadComposite(lpName);
		FreeIntPtr(lpName);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
	*/
	public static void MakeBlankFrames(int animationId, int frameCount, float duration, int color)
	{
		PluginMakeBlankFrames(animationId, frameCount, duration, color);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
	*/
	public static void MakeBlankFramesName(string path, int frameCount, float duration, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMakeBlankFramesName(lpPath, frameCount, duration, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesNameD(string path, double frameCount, double duration, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMakeBlankFramesNameD(lpPath, frameCount, duration, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by id.
	*/
	public static void MakeBlankFramesRandom(int animationId, int frameCount, float duration)
	{
		PluginMakeBlankFramesRandom(animationId, frameCount, duration);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by id.
	*/
	public static void MakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration)
	{
		PluginMakeBlankFramesRandomBlackAndWhite(animationId, frameCount, duration);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by name.
	*/
	public static void MakeBlankFramesRandomBlackAndWhiteName(string path, int frameCount, float duration)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMakeBlankFramesRandomBlackAndWhiteName(lpPath, frameCount, duration);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesRandomBlackAndWhiteNameD(string path, double frameCount, double duration)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMakeBlankFramesRandomBlackAndWhiteNameD(lpPath, frameCount, duration);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by name.
	*/
	public static void MakeBlankFramesRandomName(string path, int frameCount, float duration)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMakeBlankFramesRandomName(lpPath, frameCount, duration);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesRandomNameD(string path, double frameCount, double duration)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMakeBlankFramesRandomNameD(lpPath, frameCount, duration);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
	*/
	public static void MakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue)
	{
		PluginMakeBlankFramesRGB(animationId, frameCount, duration, red, green, blue);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
	*/
	public static void MakeBlankFramesRGBName(string path, int frameCount, float duration, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMakeBlankFramesRGBName(lpPath, frameCount, duration, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesRGBNameD(string path, double frameCount, double duration, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMakeBlankFramesRGBNameD(lpPath, frameCount, duration, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		the animation id upon success. Returns -1 upon failure.
	*/
	public static int MirrorHorizontally(int animationId)
	{
		int result = PluginMirrorHorizontally(animationId);
		return result;
	}
	/*
		Flips the color grid vertically for all `Chroma` animation frames. This 
		method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		animation id upon success. Returns -1 upon failure.
	*/
	public static int MirrorVertically(int animationId)
	{
		int result = PluginMirrorVertically(animationId);
		return result;
	}
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in id.
	*/
	public static void MultiplyColorLerpAllFrames(int animationId, int color1, int color2)
	{
		PluginMultiplyColorLerpAllFrames(animationId, color1, color2);
	}
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in name.
	*/
	public static void MultiplyColorLerpAllFramesName(string path, int color1, int color2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyColorLerpAllFramesName(lpPath, color1, color2);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyColorLerpAllFramesNameD(string path, double color1, double color2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyColorLerpAllFramesNameD(lpPath, color1, color2);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
	*/
	public static void MultiplyIntensity(int animationId, int frameId, float intensity)
	{
		PluginMultiplyIntensity(animationId, frameId, intensity);
	}
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
	*/
	public static void MultiplyIntensityAllFrames(int animationId, float intensity)
	{
		PluginMultiplyIntensityAllFrames(animationId, intensity);
	}
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
	*/
	public static void MultiplyIntensityAllFramesName(string path, float intensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyIntensityAllFramesName(lpPath, intensity);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityAllFramesNameD(string path, double intensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyIntensityAllFramesNameD(lpPath, intensity);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginMultiplyIntensityAllFramesRGB(animationId, red, green, blue);
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityAllFramesRGBName(string path, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyIntensityAllFramesRGBName(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyIntensityAllFramesRGBNameD(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityColor(int animationId, int frameId, int color)
	{
		PluginMultiplyIntensityColor(animationId, frameId, color);
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityColorAllFrames(int animationId, int color)
	{
		PluginMultiplyIntensityColorAllFrames(animationId, color);
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityColorAllFramesName(string path, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyIntensityColorAllFramesName(lpPath, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityColorAllFramesNameD(string path, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyIntensityColorAllFramesNameD(lpPath, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityColorName(string path, int frameId, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyIntensityColorName(lpPath, frameId, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityColorNameD(string path, double frameId, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyIntensityColorNameD(lpPath, frameId, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
	*/
	public static void MultiplyIntensityName(string path, int frameId, float intensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyIntensityName(lpPath, frameId, intensity);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityNameD(string path, double frameId, double intensity)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyIntensityNameD(lpPath, frameId, intensity);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginMultiplyIntensityRGB(animationId, frameId, red, green, blue);
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityRGBName(string path, int frameId, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyIntensityRGBName(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyIntensityRGBNameD(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
	*/
	public static void MultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2)
	{
		PluginMultiplyNonZeroTargetColorLerp(animationId, frameId, color1, color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2)
	{
		PluginMultiplyNonZeroTargetColorLerpAllFrames(animationId, color1, color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFramesName(string path, int color1, int color2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyNonZeroTargetColorLerpAllFramesName(lpPath, color1, color2);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyNonZeroTargetColorLerpAllFramesNameD(string path, double color1, double color2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(lpPath, color1, color2);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		id.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(animationId, red1, green1, blue1, red2, green2, blue2);
	}
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		name.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFramesRGBName(string path, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(lpPath, red1, green1, blue1, red2, green2, blue2);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyNonZeroTargetColorLerpAllFramesRGBNameD(string path, double red1, double green1, double blue1, double red2, double green2, double blue2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(lpPath, red1, green1, blue1, red2, green2, blue2);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
	*/
	public static void MultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2)
	{
		PluginMultiplyTargetColorLerp(animationId, frameId, color1, color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
	*/
	public static void MultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2)
	{
		PluginMultiplyTargetColorLerpAllFrames(animationId, color1, color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
	*/
	public static void MultiplyTargetColorLerpAllFramesName(string path, int color1, int color2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyTargetColorLerpAllFramesName(lpPath, color1, color2);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyTargetColorLerpAllFramesNameD(string path, double color1, double color2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyTargetColorLerpAllFramesNameD(lpPath, color1, color2);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by id.
	*/
	public static void MultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		PluginMultiplyTargetColorLerpAllFramesRGB(animationId, red1, green1, blue1, red2, green2, blue2);
	}
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by name.
	*/
	public static void MultiplyTargetColorLerpAllFramesRGBName(string path, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginMultiplyTargetColorLerpAllFramesRGBName(lpPath, red1, green1, blue1, red2, green2, blue2);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyTargetColorLerpAllFramesRGBNameD(string path, double red1, double green1, double blue1, double red2, double green2, double blue2)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginMultiplyTargetColorLerpAllFramesRGBNameD(lpPath, red1, green1, blue1, red2, green2, blue2);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
	*/
	public static void OffsetColors(int animationId, int frameId, int red, int green, int blue)
	{
		PluginOffsetColors(animationId, frameId, red, green, blue);
	}
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
	*/
	public static void OffsetColorsAllFrames(int animationId, int red, int green, int blue)
	{
		PluginOffsetColorsAllFrames(animationId, red, green, blue);
	}
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
	*/
	public static void OffsetColorsAllFramesName(string path, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginOffsetColorsAllFramesName(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetColorsAllFramesNameD(string path, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginOffsetColorsAllFramesNameD(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
	*/
	public static void OffsetColorsName(string path, int frameId, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginOffsetColorsName(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetColorsNameD(string path, double frameId, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginOffsetColorsNameD(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue)
	{
		PluginOffsetNonZeroColors(animationId, frameId, red, green, blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue)
	{
		PluginOffsetNonZeroColorsAllFrames(animationId, red, green, blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColorsAllFramesName(string path, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginOffsetNonZeroColorsAllFramesName(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetNonZeroColorsAllFramesNameD(string path, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginOffsetNonZeroColorsAllFramesNameD(lpPath, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColorsName(string path, int frameId, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginOffsetNonZeroColorsName(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetNonZeroColorsNameD(string path, double frameId, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginOffsetNonZeroColorsNameD(lpPath, frameId, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Opens a `Chroma` animation file so that it can be played. Returns an animation 
		id >= 0 upon success. Returns -1 if there was a failure. The animation 
		id is used in most of the API methods.
	*/
	public static int OpenAnimation(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginOpenAnimation(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double OpenAnimationD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginOpenAnimationD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		upon success. Returns -1 if there was a failure.
	*/
	public static int OpenEditorDialog(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginOpenEditorDialog(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Open the named animation in the editor dialog and play the animation at 
		start.
	*/
	public static int OpenEditorDialogAndPlay(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginOpenEditorDialogAndPlay(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double OpenEditorDialogAndPlayD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginOpenEditorDialogAndPlayD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double OpenEditorDialogD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginOpenEditorDialogD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		parameter. Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int OverrideFrameDuration(int animationId, float duration)
	{
		int result = PluginOverrideFrameDuration(animationId, duration);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double OverrideFrameDurationD(double animationId, double duration)
	{
		double result = PluginOverrideFrameDurationD(animationId, duration);
		return result;
	}
	/*
		Override the duration of all frames with the `duration` value. Animation 
		is referenced by name.
	*/
	public static void OverrideFrameDurationName(string path, float duration)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginOverrideFrameDurationName(lpPath, duration);
		FreeIntPtr(lpPath);
	}
	/*
		Pause the current animation referenced by id.
	*/
	public static void PauseAnimation(int animationId)
	{
		PluginPauseAnimation(animationId);
	}
	/*
		Pause the current animation referenced by name.
	*/
	public static void PauseAnimationName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginPauseAnimationName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PauseAnimationNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginPauseAnimationNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Plays the `Chroma` animation. This will load the animation, if not loaded 
		previously. Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int PlayAnimation(int animationId)
	{
		int result = PluginPlayAnimation(animationId);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayAnimationD(double animationId)
	{
		double result = PluginPlayAnimationD(animationId);
		return result;
	}
	/*
		`PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off` starting at the `frameId`.
	*/
	public static void PlayAnimationFrame(int animationId, int frameId, bool loop)
	{
		PluginPlayAnimationFrame(animationId, frameId, loop);
	}
	/*
		`PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off` starting at the `frameId`.
	*/
	public static void PlayAnimationFrameName(string path, int frameId, bool loop)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginPlayAnimationFrameName(lpPath, frameId, loop);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayAnimationFrameNameD(string path, double frameId, double loop)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginPlayAnimationFrameNameD(lpPath, frameId, loop);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		`PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off`.
	*/
	public static void PlayAnimationLoop(int animationId, bool loop)
	{
		PluginPlayAnimationLoop(animationId, loop);
	}
	/*
		`PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off`.
	*/
	public static void PlayAnimationName(string path, bool loop)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginPlayAnimationName(lpPath, loop);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayAnimationNameD(string path, double loop)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginPlayAnimationNameD(lpPath, loop);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		`PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will play with looping `on` or `off`.
	*/
	public static void PlayComposite(string name, bool loop)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		PluginPlayComposite(lpName, loop);
		FreeIntPtr(lpName);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayCompositeD(string name, double loop)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		double result = PluginPlayCompositeD(lpName, loop);
		FreeIntPtr(lpName);
		return result;
	}
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int PreviewFrame(int animationId, int frameIndex)
	{
		int result = PluginPreviewFrame(animationId, frameIndex);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double PreviewFrameD(double animationId, double frameIndex)
	{
		double result = PluginPreviewFrameD(animationId, frameIndex);
		return result;
	}
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Animaton is referenced by name.
	*/
	public static void PreviewFrameName(string path, int frameIndex)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginPreviewFrameName(lpPath, frameIndex);
		FreeIntPtr(lpPath);
	}
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by id.
	*/
	public static void ReduceFrames(int animationId, int n)
	{
		PluginReduceFrames(animationId, n);
	}
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by name.
	*/
	public static void ReduceFramesName(string path, int n)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginReduceFramesName(lpPath, n);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double ReduceFramesNameD(string path, double n)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginReduceFramesNameD(lpPath, n);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		upon success. Returns -1 upon failure.
	*/
	public static int ResetAnimation(int animationId)
	{
		int result = PluginResetAnimation(animationId);
		return result;
	}
	/*
		Resume the animation with loop `ON` or `OFF` referenced by id.
	*/
	public static void ResumeAnimation(int animationId, bool loop)
	{
		PluginResumeAnimation(animationId, loop);
	}
	/*
		Resume the animation with loop `ON` or `OFF` referenced by name.
	*/
	public static void ResumeAnimationName(string path, bool loop)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginResumeAnimationName(lpPath, loop);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double ResumeAnimationNameD(string path, double loop)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginResumeAnimationNameD(lpPath, loop);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Reverse the animation frame order of the `Chroma` animation. Returns the 
		animation id upon success. Returns -1 upon failure. Animation is referenced 
		by id.
	*/
	public static int Reverse(int animationId)
	{
		int result = PluginReverse(animationId);
		return result;
	}
	/*
		Reverse the animation frame order of the `Chroma` animation. Animation is 
		referenced by id.
	*/
	public static void ReverseAllFrames(int animationId)
	{
		PluginReverseAllFrames(animationId);
	}
	/*
		Reverse the animation frame order of the `Chroma` animation. Animation is 
		referenced by name.
	*/
	public static void ReverseAllFramesName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginReverseAllFramesName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double ReverseAllFramesNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginReverseAllFramesNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Save the animation referenced by id to the path specified.
	*/
	public static int SaveAnimation(int animationId, string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		int result = PluginSaveAnimation(animationId, lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Save the named animation to the target path specified.
	*/
	public static int SaveAnimationName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		int result = PluginSaveAnimationName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by id.
	*/
	public static void Set1DColor(int animationId, int frameId, int led, int color)
	{
		PluginSet1DColor(animationId, frameId, led, color);
	}
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by name.
	*/
	public static void Set1DColorName(string path, int frameId, int led, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSet1DColorName(lpPath, frameId, led, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double Set1DColorNameD(string path, double frameId, double led, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSet1DColorNameD(lpPath, frameId, led, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by id.
	*/
	public static void Set2DColor(int animationId, int frameId, int row, int column, int color)
	{
		PluginSet2DColor(animationId, frameId, row, column, color);
	}
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by name.
	*/
	public static void Set2DColorName(string path, int frameId, int row, int column, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSet2DColorName(lpPath, frameId, row, column, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double Set2DColorNameD(string path, double frameId, double rowColumnIndex, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSet2DColorNameD(lpPath, frameId, rowColumnIndex, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		When custom color is set, the custom key mode will be used. The animation 
		is referenced by id.
	*/
	public static void SetChromaCustomColorAllFrames(int animationId)
	{
		PluginSetChromaCustomColorAllFrames(animationId);
	}
	/*
		When custom color is set, the custom key mode will be used. The animation 
		is referenced by name.
	*/
	public static void SetChromaCustomColorAllFramesName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetChromaCustomColorAllFramesName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetChromaCustomColorAllFramesNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetChromaCustomColorAllFramesNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by id.
	*/
	public static void SetChromaCustomFlag(int animationId, bool flag)
	{
		PluginSetChromaCustomFlag(animationId, flag);
	}
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by name.
	*/
	public static void SetChromaCustomFlagName(string path, bool flag)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetChromaCustomFlagName(lpPath, flag);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetChromaCustomFlagNameD(string path, double flag)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetChromaCustomFlagNameD(lpPath, flag);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the current frame of the animation referenced by id.
	*/
	public static void SetCurrentFrame(int animationId, int frameId)
	{
		PluginSetCurrentFrame(animationId, frameId);
	}
	/*
		Set the current frame of the animation referenced by name.
	*/
	public static void SetCurrentFrameName(string path, int frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetCurrentFrameName(lpPath, frameId);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetCurrentFrameNameD(string path, double frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetCurrentFrameNameD(lpPath, frameId);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		the animation id upon success. Returns -1 upon failure.
	*/
	public static int SetDevice(int animationId, int deviceType, int device)
	{
		int result = PluginSetDevice(animationId, deviceType, device);
		return result;
	}
	/*
		SetEffect will display the referenced effect id.
	*/
	public static int SetEffect(System.Guid effectId)
	{
		int result = PluginSetEffect(effectId);
		return result;
	}
	/*
		Set animation key to a static color for the given frame.
	*/
	public static void SetKeyColor(int animationId, int frameId, int rzkey, int color)
	{
		PluginSetKeyColor(animationId, frameId, rzkey, color);
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
	*/
	public static void SetKeyColorAllFrames(int animationId, int rzkey, int color)
	{
		PluginSetKeyColorAllFrames(animationId, rzkey, color);
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
	*/
	public static void SetKeyColorAllFramesName(string path, int rzkey, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyColorAllFramesName(lpPath, rzkey, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorAllFramesNameD(string path, double rzkey, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyColorAllFramesNameD(lpPath, rzkey, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
	*/
	public static void SetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyColorAllFramesRGB(animationId, rzkey, red, green, blue);
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
	*/
	public static void SetKeyColorAllFramesRGBName(string path, int rzkey, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyColorAllFramesRGBName(lpPath, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorAllFramesRGBNameD(string path, double rzkey, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyColorAllFramesRGBNameD(lpPath, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set animation key to a static color for the given frame.
	*/
	public static void SetKeyColorName(string path, int frameId, int rzkey, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyColorName(lpPath, frameId, rzkey, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorNameD(string path, double frameId, double rzkey, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyColorNameD(lpPath, frameId, rzkey, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by id.
	*/
	public static void SetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyColorRGB(animationId, frameId, rzkey, red, green, blue);
	}
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by name.
	*/
	public static void SetKeyColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyColorRGBName(lpPath, frameId, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyColorRGBNameD(lpPath, frameId, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
	*/
	public static void SetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color)
	{
		PluginSetKeyNonZeroColor(animationId, frameId, rzkey, color);
	}
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
	*/
	public static void SetKeyNonZeroColorName(string path, int frameId, int rzkey, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyNonZeroColorName(lpPath, frameId, rzkey, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyNonZeroColorNameD(string path, double frameId, double rzkey, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyNonZeroColorNameD(lpPath, frameId, rzkey, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by id.
	*/
	public static void SetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyNonZeroColorRGB(animationId, frameId, rzkey, red, green, blue);
	}
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by name.
	*/
	public static void SetKeyNonZeroColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyNonZeroColorRGBName(lpPath, frameId, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyNonZeroColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyNonZeroColorRGBNameD(lpPath, frameId, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
	*/
	public static void SetKeysColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysColor(animationId, frameId, rzkeys, keyCount, color);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
	*/
	public static void SetKeysColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysColorAllFrames(animationId, rzkeys, keyCount, color);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
	*/
	public static void SetKeysColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysColorAllFramesName(lpPath, rzkeys, keyCount, color);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
	*/
	public static void SetKeysColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysColorAllFramesRGB(animationId, rzkeys, keyCount, red, green, blue);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
	*/
	public static void SetKeysColorAllFramesRGBName(string path, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysColorAllFramesRGBName(lpPath, rzkeys, keyCount, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame.
	*/
	public static void SetKeysColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysColorName(lpPath, frameId, rzkeys, keyCount, color);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
	*/
	public static void SetKeysColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by name.
	*/
	public static void SetKeysColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysColorRGBName(lpPath, frameId, rzkeys, keyCount, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black.
	*/
	public static void SetKeysNonZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysNonZeroColor(animationId, frameId, rzkeys, keyCount, color);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
	*/
	public static void SetKeysNonZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysNonZeroColorAllFrames(animationId, rzkeys, keyCount, color);
	}
	/*
		Set an array of animation keys to a static color for all frames if the existing 
		color is not already black. Reference animation by name.
	*/
	public static void SetKeysNonZeroColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysNonZeroColorAllFramesName(lpPath, rzkeys, keyCount, color);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black. Reference animation by name.
	*/
	public static void SetKeysNonZeroColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysNonZeroColorName(lpPath, frameId, rzkeys, keyCount, color);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
	*/
	public static void SetKeysNonZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysNonZeroColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by name.
	*/
	public static void SetKeysNonZeroColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysNonZeroColorRGBName(lpPath, frameId, rzkeys, keyCount, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysZeroColor(animationId, frameId, rzkeys, keyCount, color);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysZeroColorAllFrames(animationId, rzkeys, keyCount, color);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysZeroColorAllFramesName(lpPath, rzkeys, keyCount, color);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysZeroColorAllFramesRGB(animationId, rzkeys, keyCount, red, green, blue);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorAllFramesRGBName(string path, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysZeroColorAllFramesRGBName(lpPath, rzkeys, keyCount, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysZeroColorName(lpPath, frameId, rzkeys, keyCount, color);
		FreeIntPtr(lpPath);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysZeroColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeysZeroColorRGBName(lpPath, frameId, rzkeys, keyCount, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
	*/
	public static void SetKeyZeroColor(int animationId, int frameId, int rzkey, int color)
	{
		PluginSetKeyZeroColor(animationId, frameId, rzkey, color);
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
	*/
	public static void SetKeyZeroColorName(string path, int frameId, int rzkey, int color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyZeroColorName(lpPath, frameId, rzkey, color);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyZeroColorNameD(string path, double frameId, double rzkey, double color)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyZeroColorNameD(lpPath, frameId, rzkey, color);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
	*/
	public static void SetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyZeroColorRGB(animationId, frameId, rzkey, red, green, blue);
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
	*/
	public static void SetKeyZeroColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginSetKeyZeroColorRGBName(lpPath, frameId, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyZeroColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginSetKeyZeroColorRGBNameD(lpPath, frameId, rzkey, red, green, blue);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Invokes the setup for a debug logging callback so that `stdout` is redirected 
		to the callback. This is used by `Unity` so that debug messages can appear 
		in the console window.
	*/
	public static void SetLogDelegate(DebugLogPtr fp)
	{
		PluginSetLogDelegate(fp);
	}
	/*
		`PluginStopAll` will automatically stop all animations that are playing.
	*/
	public static void StopAll()
	{
		PluginStopAll();
	}
	/*
		Stops animation playback if in progress. Returns the animation id upon success. 
		Returns -1 upon failure.
	*/
	public static int StopAnimation(int animationId)
	{
		int result = PluginStopAnimation(animationId);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopAnimationD(double animationId)
	{
		double result = PluginStopAnimationD(animationId);
		return result;
	}
	/*
		`PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will stop if playing.
	*/
	public static void StopAnimationName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginStopAnimationName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopAnimationNameD(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginStopAnimationNameD(lpPath);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		`PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		it will be stopped.
	*/
	public static void StopAnimationType(int deviceType, int device)
	{
		PluginStopAnimationType(deviceType, device);
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopAnimationTypeD(double deviceType, double device)
	{
		double result = PluginStopAnimationTypeD(deviceType, device);
		return result;
	}
	/*
		`PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will be stopped if playing.
	*/
	public static void StopComposite(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		PluginStopComposite(lpName);
		FreeIntPtr(lpName);
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopCompositeD(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		double result = PluginStopCompositeD(lpName);
		FreeIntPtr(lpName);
		return result;
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by id.
	*/
	public static void SubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginSubtractNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by name.
	*/
	public static void SubtractNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginSubtractNonZeroAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginSubtractNonZeroAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by id.
	*/
	public static void SubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginSubtractNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by name.
	*/
	public static void SubtractNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginSubtractNonZeroAllKeysAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by id.
	*/
	public static void SubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginSubtractNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
	}
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by name.
	*/
	public static void SubtractNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginSubtractNonZeroAllKeysOffsetName(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginSubtractNonZeroAllKeysOffsetNameD(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by id.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginSubtractNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by name.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginSubtractNonZeroTargetAllKeysAllFramesName(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginSubtractNonZeroTargetAllKeysAllFramesNameD(lpSourceAnimation, lpTargetAnimation);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by id.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginSubtractNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by name.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(lpSourceAnimation, lpTargetAnimation, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by id.
	*/
	public static void SubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginSubtractNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by name.
	*/
	public static void SubtractNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		PluginSubtractNonZeroTargetAllKeysOffsetName(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		string pathSourceAnimation = GetStreamingPath(sourceAnimation);
		IntPtr lpSourceAnimation = GetIntPtr(pathSourceAnimation);
		string pathTargetAnimation = GetStreamingPath(targetAnimation);
		IntPtr lpTargetAnimation = GetIntPtr(pathTargetAnimation);
		double result = PluginSubtractNonZeroTargetAllKeysOffsetNameD(lpSourceAnimation, lpTargetAnimation, frameId, offset);
		FreeIntPtr(lpSourceAnimation);
		FreeIntPtr(lpTargetAnimation);
		return result;
	}
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by id.
	*/
	public static void TrimEndFrames(int animationId, int lastFrameId)
	{
		PluginTrimEndFrames(animationId, lastFrameId);
	}
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by name.
	*/
	public static void TrimEndFramesName(string path, int lastFrameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginTrimEndFramesName(lpPath, lastFrameId);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double TrimEndFramesNameD(string path, double lastFrameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginTrimEndFramesNameD(lpPath, lastFrameId);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Remove the frame from the animation. Reference animation by id.
	*/
	public static void TrimFrame(int animationId, int frameId)
	{
		PluginTrimFrame(animationId, frameId);
	}
	/*
		Remove the frame from the animation. Reference animation by name.
	*/
	public static void TrimFrameName(string path, int frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginTrimFrameName(lpPath, frameId);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double TrimFrameNameD(string path, double frameId)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginTrimFrameNameD(lpPath, frameId);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by id.
	*/
	public static void TrimStartFrames(int animationId, int numberOfFrames)
	{
		PluginTrimStartFrames(animationId, numberOfFrames);
	}
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by name.
	*/
	public static void TrimStartFramesName(string path, int numberOfFrames)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginTrimStartFramesName(lpPath, numberOfFrames);
		FreeIntPtr(lpPath);
	}
	/*
		D suffix for limited data types.
	*/
	public static double TrimStartFramesNameD(string path, double numberOfFrames)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		double result = PluginTrimStartFramesNameD(lpPath, numberOfFrames);
		FreeIntPtr(lpPath);
		return result;
	}
	/*
		Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns -1 upon failure.
	*/
	public static int Uninit()
	{
		int result = PluginUninit();
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double UninitD()
	{
		double result = PluginUninitD();
		return result;
	}
	/*
		Unloads `Chroma` effects to free up resources. Returns the animation id 
		upon success. Returns -1 upon failure. Reference the animation by id.
	*/
	public static int UnloadAnimation(int animationId)
	{
		int result = PluginUnloadAnimation(animationId);
		return result;
	}
	/*
		D suffix for limited data types.
	*/
	public static double UnloadAnimationD(double animationId)
	{
		double result = PluginUnloadAnimationD(animationId);
		return result;
	}
	/*
		Unload the animation effects. Reference the animation by name.
	*/
	public static void UnloadAnimationName(string path)
	{
		string pathPath = GetStreamingPath(path);
		IntPtr lpPath = GetIntPtr(pathPath);
		PluginUnloadAnimationName(lpPath);
		FreeIntPtr(lpPath);
	}
	/*
		Unload the the composite set of animation effects. Reference the animation 
		by name.
	*/
	public static void UnloadComposite(string name)
	{
		string pathName = GetStreamingPath(name);
		IntPtr lpName = GetIntPtr(pathName);
		PluginUnloadComposite(lpName);
		FreeIntPtr(lpName);
	}
	/*
		Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		(in seconds). The `color` is expected to be an array of the dimensions 
		for the `deviceType/device`. The `length` parameter is the size of the 
		`color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		* `MAX COLUMN`. Returns the animation id upon success. Returns -1 upon 
		failure.
	*/
	public static int UpdateFrame(int animationId, int frameIndex, float duration, int[] colors, int length)
	{
		int result = PluginUpdateFrame(animationId, frameIndex, duration, colors, length);
		return result;
	}
#endregion

#region Private DLL Hooks
	/*
		Adds a frame to the `Chroma` animation and sets the `duration` (in seconds). 
		The `color` is expected to be an array of the dimensions for the `deviceType/device`. 
		The `length` parameter is the size of the `color` array. For `EChromaSDKDevice1DEnum` 
		the array size should be `MAX LEDS`. For `EChromaSDKDevice2DEnum` the array 
		size should be `MAX ROW` * `MAX COLUMN`. Returns the animation id upon 
		success. Returns -1 upon failure.
		EXPORT_API int PluginAddFrame(int animationId, float duration, int* colors, int length);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginAddFrame(int animationId, float duration, int[] colors, int length);
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by id.
		EXPORT_API void PluginAddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by name.
		EXPORT_API void PluginAddNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginAddNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		id.
		EXPORT_API void PluginAddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		name.
		EXPORT_API void PluginAddNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginAddNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by id.
		EXPORT_API void PluginAddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by name.
		EXPORT_API void PluginAddNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginAddNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by id.
		EXPORT_API void PluginAddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by name.
		EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginAddNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by id.
		EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by name.
		EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by id.
		EXPORT_API void PluginAddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by name.
		EXPORT_API void PluginAddNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginAddNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Append all source frames to the target animation, reference source and target 
		by id.
		EXPORT_API void PluginAppendAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAppendAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Append all source frames to the target animation, reference source and target 
		by name.
		EXPORT_API void PluginAppendAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAppendAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginAppendAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAppendAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		`PluginClearAll` will issue a `CLEAR` effect for all devices.
		EXPORT_API void PluginClearAll();
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginClearAll();
	/*
		`PluginClearAnimationType` will issue a `CLEAR` effect for the given device.
		EXPORT_API void PluginClearAnimationType(int deviceType, int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginClearAnimationType(int deviceType, int device);
	/*
		`PluginCloseAll` closes all open animations so they can be reloaded from 
		disk. The set of animations will be stopped if playing.
		EXPORT_API void PluginCloseAll();
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCloseAll();
	/*
		Closes the `Chroma` animation to free up resources referenced by id. Returns 
		the animation id upon success. Returns -1 upon failure. This might be used 
		while authoring effects if there was a change necessitating re-opening 
		the animation. The animation id can no longer be used once closed.
		EXPORT_API int PluginCloseAnimation(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCloseAnimation(int animationId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCloseAnimationD(double animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCloseAnimationD(double animationId);
	/*
		Closes the `Chroma` animation referenced by name so that the animation can 
		be reloaded from disk.
		EXPORT_API void PluginCloseAnimationName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCloseAnimationName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCloseAnimationNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCloseAnimationNameD(IntPtr path);
	/*
		`PluginCloseComposite` closes a set of animations so they can be reloaded 
		from disk. The set of animations will be stopped if playing.
		EXPORT_API void PluginCloseComposite(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCloseComposite(IntPtr name);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCloseCompositeD(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCloseCompositeD(IntPtr name);
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by id.
		EXPORT_API int PluginCopyAnimation(int sourceAnimationId, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCopyAnimation(int sourceAnimationId, IntPtr targetAnimation);
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by name.
		EXPORT_API void PluginCopyAnimationName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyAnimationName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyAnimationNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyAnimationNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
		EXPORT_API void PluginCopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity);
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by name.
		EXPORT_API void PluginCopyBlueChannelAllFramesName(const char* path, float redIntensity, float greenIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyBlueChannelAllFramesName(IntPtr path, float redIntensity, float greenIntensity);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyBlueChannelAllFramesNameD(const char* path, double redIntensity, double greenIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyBlueChannelAllFramesNameD(IntPtr path, double redIntensity, double greenIntensity);
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by id.
		EXPORT_API void PluginCopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity);
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
		EXPORT_API void PluginCopyGreenChannelAllFramesName(const char* path, float redIntensity, float blueIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyGreenChannelAllFramesName(IntPtr path, float redIntensity, float blueIntensity);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyGreenChannelAllFramesNameD(const char* path, double redIntensity, double blueIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyGreenChannelAllFramesNameD(IntPtr path, double redIntensity, double blueIntensity);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame. Reference the source and target by id.
		EXPORT_API void PluginCopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by id.
		EXPORT_API void PluginCopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by name.
		EXPORT_API void PluginCopyKeyColorAllFramesName(const char* sourceAnimation, const char* targetAnimation, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation, int rzkey);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyKeyColorAllFramesNameD(const char* sourceAnimation, const char* targetAnimation, double rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyKeyColorAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by id.
		EXPORT_API void PluginCopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by name.
		EXPORT_API void PluginCopyKeyColorAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int rzkey, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int rzkey, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyKeyColorAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double rzkey, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyKeyColorAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double rzkey, double offset);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame.
		EXPORT_API void PluginCopyKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
	/*
		Copy source animation to target animation for the given frame. Source and 
		target are referenced by id.
		EXPORT_API void PluginCopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by id.
		EXPORT_API void PluginCopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by name.
		EXPORT_API void PluginCopyNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by id.
		EXPORT_API void PluginCopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by name.
		EXPORT_API void PluginCopyNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Copy nonzero colors from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
		EXPORT_API void PluginCopyNonZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroAllKeysNameD(const char* sourceAnimation, const char* targetAnimation, double frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId);
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by id.
		EXPORT_API void PluginCopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by name.
		EXPORT_API void PluginCopyNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
		EXPORT_API void PluginCopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
		EXPORT_API void PluginCopyNonZeroKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. Source and target 
		are referenced by id.
		EXPORT_API void PluginCopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by id.
		EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
		EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
		EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames starting at the target offset 
		for the length of the source animation. Source and target animations are 
		referenced by name.
		EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. The source and target 
		are referenced by name.
		EXPORT_API void PluginCopyNonZeroTargetAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroTargetAllKeysNameD(const char* sourceAnimation, const char* targetAnimation, double frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by id.
		EXPORT_API void PluginCopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by name.
		EXPORT_API void PluginCopyNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Copy red channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
		EXPORT_API void PluginCopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity);
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
		EXPORT_API void PluginCopyRedChannelAllFramesName(const char* path, float greenIntensity, float blueIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyRedChannelAllFramesName(IntPtr path, float greenIntensity, float blueIntensity);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyRedChannelAllFramesNameD(const char* path, double greenIntensity, double blueIntensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyRedChannelAllFramesNameD(IntPtr path, double greenIntensity, double blueIntensity);
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by id.
		EXPORT_API void PluginCopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by name.
		EXPORT_API void PluginCopyZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by id.
		EXPORT_API void PluginCopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by name.
		EXPORT_API void PluginCopyZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
		EXPORT_API void PluginCopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by name.
		EXPORT_API void PluginCopyZeroKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyZeroKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by id.
		EXPORT_API void PluginCopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by name.
		EXPORT_API void PluginCopyZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginCopyZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreCreateChromaLinkEffect(ChromaSDK::ChromaLink::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID *pEffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateChromaLinkEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreCreateEffect(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID *pEffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateEffect(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreCreateHeadsetEffect(ChromaSDK::Headset::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID *pEffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateHeadsetEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreCreateKeyboardEffect(ChromaSDK::Keyboard::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID *pEffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateKeyboardEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreCreateKeypadEffect(ChromaSDK::Keypad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID *pEffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateKeypadEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreCreateMouseEffect(ChromaSDK::Mouse::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID *pEffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateMouseEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreCreateMousepadEffect(ChromaSDK::Mousepad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID *pEffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateMousepadEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreDeleteEffect(RZEFFECTID EffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreDeleteEffect(RZEFFECTID EffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreInit();
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreInit();
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreQueryDevice(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE &DeviceInfo);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreQueryDevice(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE DeviceInfo);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreSetEffect(RZEFFECTID EffectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreSetEffect(RZEFFECTID EffectId);
	/*
		Direct access to low level API.
		EXPORT_API RZRESULT PluginCoreUnInit();
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreUnInit();
	/*
		Creates a `Chroma` animation at the given path. The `deviceType` parameter 
		uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter uses 
		`EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, respective 
		to the `deviceType`. Returns the animation id upon success. Returns -1 
		upon failure. Saves a `Chroma` animation file with the `.chroma` extension 
		at the given path. Returns the animation id upon success. Returns -1 upon 
		failure.
		EXPORT_API int PluginCreateAnimation(const char* path, int deviceType, int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCreateAnimation(IntPtr path, int deviceType, int device);
	/*
		Creates a `Chroma` animation in memory without creating a file. The `deviceType` 
		parameter uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter 
		uses `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, 
		respective to the `deviceType`. Returns the animation id upon success. 
		Returns -1 upon failure. Returns the animation id upon success. Returns 
		-1 upon failure.
		EXPORT_API int PluginCreateAnimationInMemory(int deviceType, int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCreateAnimationInMemory(int deviceType, int device);
	/*
		Create a device specific effect.
		EXPORT_API RZRESULT PluginCreateEffect(RZDEVICEID deviceId, ChromaSDK::EFFECT_TYPE effect, int* colors, int size, ChromaSDK::FChromaSDKGuid* effectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCreateEffect(RZDEVICEID deviceId, ChromaSDK::EFFECT_TYPE effect, int[] colors, int size, ChromaSDK::FChromaSDKGuid* effectId);
	/*
		Delete an effect given the effect id.
		EXPORT_API RZRESULT PluginDeleteEffect(const ChromaSDK::FChromaSDKGuid& effectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginDeleteEffect(System.Guid effectId);
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by id.
		EXPORT_API void PluginDuplicateFirstFrame(int animationId, int frameCount);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFirstFrame(int animationId, int frameCount);
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by name.
		EXPORT_API void PluginDuplicateFirstFrameName(const char* path, int frameCount);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFirstFrameName(IntPtr path, int frameCount);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginDuplicateFirstFrameNameD(const char* path, double frameCount);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginDuplicateFirstFrameNameD(IntPtr path, double frameCount);
	/*
		Duplicate all the frames of the animation to double the animation length. 
		Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		The animation is referenced by id.
		EXPORT_API void PluginDuplicateFrames(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFrames(int animationId);
	/*
		Duplicate all the frames of the animation to double the animation length. 
		Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		The animation is referenced by name.
		EXPORT_API void PluginDuplicateFramesName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFramesName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginDuplicateFramesNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginDuplicateFramesNameD(IntPtr path);
	/*
		Duplicate all the animation frames in reverse so that the animation plays 
		forwards and backwards. Animation is referenced by id.
		EXPORT_API void PluginDuplicateMirrorFrames(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateMirrorFrames(int animationId);
	/*
		Duplicate all the animation frames in reverse so that the animation plays 
		forwards and backwards. Animation is referenced by name.
		EXPORT_API void PluginDuplicateMirrorFramesName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateMirrorFramesName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginDuplicateMirrorFramesNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginDuplicateMirrorFramesNameD(IntPtr path);
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by id.
		EXPORT_API void PluginFadeEndFrames(int animationId, int fade);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeEndFrames(int animationId, int fade);
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by name.
		EXPORT_API void PluginFadeEndFramesName(const char* path, int fade);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeEndFramesName(IntPtr path, int fade);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFadeEndFramesNameD(const char* path, double fade);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFadeEndFramesNameD(IntPtr path, double fade);
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by id.
		EXPORT_API void PluginFadeStartFrames(int animationId, int fade);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeStartFrames(int animationId, int fade);
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by name.
		EXPORT_API void PluginFadeStartFramesName(const char* path, int fade);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeStartFramesName(IntPtr path, int fade);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFadeStartFramesNameD(const char* path, double fade);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFadeStartFramesNameD(IntPtr path, double fade);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
		EXPORT_API void PluginFillColor(int animationId, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColor(int animationId, int frameId, int color);
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by id.
		EXPORT_API void PluginFillColorAllFrames(int animationId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFrames(int animationId, int color);
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by name.
		EXPORT_API void PluginFillColorAllFramesName(const char* path, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillColorAllFramesNameD(const char* path, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorAllFramesNameD(IntPtr path, double color);
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by id.
		EXPORT_API void PluginFillColorAllFramesRGB(int animationId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by name.
		EXPORT_API void PluginFillColorAllFramesRGBName(const char* path, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
		EXPORT_API void PluginFillColorName(const char* path, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillColorNameD(const char* path, double frameId, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorNameD(IntPtr path, double frameId, double color);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
		EXPORT_API void PluginFillColorRGB(int animationId, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
		EXPORT_API void PluginFillColorRGBName(const char* path, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by id.
		EXPORT_API void PluginFillNonZeroColor(int animationId, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColor(int animationId, int frameId, int color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by id.
		EXPORT_API void PluginFillNonZeroColorAllFrames(int animationId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFrames(int animationId, int color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by name.
		EXPORT_API void PluginFillNonZeroColorAllFramesName(const char* path, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillNonZeroColorAllFramesNameD(const char* path, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorAllFramesNameD(IntPtr path, double color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
		EXPORT_API void PluginFillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
		EXPORT_API void PluginFillNonZeroColorAllFramesRGBName(const char* path, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillNonZeroColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by name.
		EXPORT_API void PluginFillNonZeroColorName(const char* path, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillNonZeroColorNameD(const char* path, double frameId, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorNameD(IntPtr path, double frameId, double color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
		EXPORT_API void PluginFillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
		EXPORT_API void PluginFillNonZeroColorRGBName(const char* path, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillNonZeroColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by id.
		EXPORT_API void PluginFillRandomColors(int animationId, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColors(int animationId, int frameId);
	/*
		Fill the frame with random RGB values for all frames. Animation is referenced 
		by id.
		EXPORT_API void PluginFillRandomColorsAllFrames(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsAllFrames(int animationId);
	/*
		Fill the frame with random RGB values for all frames. Animation is referenced 
		by name.
		EXPORT_API void PluginFillRandomColorsAllFramesName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillRandomColorsAllFramesNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsAllFramesNameD(IntPtr path);
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by id.
		EXPORT_API void PluginFillRandomColorsBlackAndWhite(int animationId, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhite(int animationId, int frameId);
	/*
		Fill the frame with random black and white values for all frames. Animation 
		is referenced by id.
		EXPORT_API void PluginFillRandomColorsBlackAndWhiteAllFrames(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhiteAllFrames(int animationId);
	/*
		Fill the frame with random black and white values for all frames. Animation 
		is referenced by name.
		EXPORT_API void PluginFillRandomColorsBlackAndWhiteAllFramesName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhiteAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillRandomColorsBlackAndWhiteAllFramesNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsBlackAndWhiteAllFramesNameD(IntPtr path);
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by name.
		EXPORT_API void PluginFillRandomColorsBlackAndWhiteName(const char* path, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhiteName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillRandomColorsBlackAndWhiteNameD(const char* path, double frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsBlackAndWhiteNameD(IntPtr path, double frameId);
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by name.
		EXPORT_API void PluginFillRandomColorsName(const char* path, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillRandomColorsNameD(const char* path, double frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsNameD(IntPtr path, double frameId);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdColors(int animationId, int frameId, int threshold, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColors(int animationId, int frameId, int threshold, int color);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdColorsAllFrames(int animationId, int threshold, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFrames(int animationId, int threshold, int color);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdColorsAllFramesName(const char* path, int threshold, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFramesName(IntPtr path, int threshold, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdColorsAllFramesNameD(const char* path, double threshold, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsAllFramesNameD(IntPtr path, double threshold, double color);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdColorsAllFramesRGBName(const char* path, int threshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFramesRGBName(IntPtr path, int threshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdColorsAllFramesRGBNameD(const char* path, double threshold, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsAllFramesRGBNameD(IntPtr path, double threshold, double red, double green, double blue);
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdColorsMinMaxAllFramesRGBName(const char* path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxAllFramesRGBName(IntPtr path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdColorsMinMaxAllFramesRGBNameD(const char* path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsMinMaxAllFramesRGBNameD(IntPtr path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdColorsMinMaxRGBName(const char* path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxRGBName(IntPtr path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdColorsMinMaxRGBNameD(const char* path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsMinMaxRGBNameD(IntPtr path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdColorsName(const char* path, int frameId, int threshold, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsName(IntPtr path, int frameId, int threshold, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdColorsNameD(const char* path, double frameId, double threshold, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsNameD(IntPtr path, double frameId, double threshold, double color);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdColorsRGBName(const char* path, int frameId, int threshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsRGBName(IntPtr path, int frameId, int threshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdColorsRGBNameD(const char* path, double frameId, double threshold, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsRGBNameD(IntPtr path, double frameId, double threshold, double red, double green, double blue);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdRGBColorsAllFramesRGBName(const char* path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsAllFramesRGBName(IntPtr path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdRGBColorsAllFramesRGBNameD(const char* path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdRGBColorsAllFramesRGBNameD(IntPtr path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
		EXPORT_API void PluginFillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
		EXPORT_API void PluginFillThresholdRGBColorsRGBName(const char* path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsRGBName(IntPtr path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillThresholdRGBColorsRGBNameD(const char* path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdRGBColorsRGBNameD(IntPtr path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
		EXPORT_API void PluginFillZeroColor(int animationId, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColor(int animationId, int frameId, int color);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
		EXPORT_API void PluginFillZeroColorAllFrames(int animationId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFrames(int animationId, int color);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
		EXPORT_API void PluginFillZeroColorAllFramesName(const char* path, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillZeroColorAllFramesNameD(const char* path, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorAllFramesNameD(IntPtr path, double color);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
		EXPORT_API void PluginFillZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
		EXPORT_API void PluginFillZeroColorAllFramesRGBName(const char* path, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillZeroColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
		EXPORT_API void PluginFillZeroColorName(const char* path, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillZeroColorNameD(const char* path, double frameId, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorNameD(IntPtr path, double frameId, double color);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
		EXPORT_API void PluginFillZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
		EXPORT_API void PluginFillZeroColorRGBName(const char* path, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginFillZeroColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by id.
		EXPORT_API int PluginGet1DColor(int animationId, int frameId, int led);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet1DColor(int animationId, int frameId, int led);
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by name.
		EXPORT_API int PluginGet1DColorName(const char* path, int frameId, int led);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet1DColorName(IntPtr path, int frameId, int led);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGet1DColorNameD(const char* path, double frameId, double led);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGet1DColorNameD(IntPtr path, double frameId, double led);
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by id.
		EXPORT_API int PluginGet2DColor(int animationId, int frameId, int row, int column);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet2DColor(int animationId, int frameId, int row, int column);
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by name.
		EXPORT_API int PluginGet2DColorName(const char* path, int frameId, int row, int column);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet2DColorName(IntPtr path, int frameId, int row, int column);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGet2DColorNameD(const char* path, double frameId, double row, double column);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGet2DColorNameD(IntPtr path, double frameId, double row, double column);
	/*
		Get the animation id for the named animation.
		EXPORT_API int PluginGetAnimation(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetAnimation(IntPtr name);
	/*
		`PluginGetAnimationCount` will return the number of loaded animations.
		EXPORT_API int PluginGetAnimationCount();
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetAnimationCount();
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetAnimationD(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetAnimationD(IntPtr name);
	/*
		`PluginGetAnimationId` will return the `animationId` given the `index` of 
		the loaded animation. The `index` is zero-based and less than the number 
		returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		get the name of the animation.
		EXPORT_API int PluginGetAnimationId(int index);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetAnimationId(int index);
	/*
		`PluginGetAnimationName` takes an `animationId` and returns the name of 
		the animation of the `.chroma` animation file. If a name is not available 
		then an empty string will be returned.
		EXPORT_API const char* PluginGetAnimationName(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern IntPtr PluginGetAnimationName(int animationId);
	/*
		Get the current frame of the animation referenced by id.
		EXPORT_API int PluginGetCurrentFrame(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetCurrentFrame(int animationId);
	/*
		Get the current frame of the animation referenced by name.
		EXPORT_API int PluginGetCurrentFrameName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetCurrentFrameName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetCurrentFrameNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetCurrentFrameNameD(IntPtr path);
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
		EXPORT_API int PluginGetDevice(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDevice(int animationId);
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
		EXPORT_API int PluginGetDeviceName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDeviceName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetDeviceNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetDeviceNameD(IntPtr path);
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
		EXPORT_API int PluginGetDeviceType(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDeviceType(int animationId);
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
		EXPORT_API int PluginGetDeviceTypeName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDeviceTypeName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetDeviceTypeNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetDeviceTypeNameD(IntPtr path);
	/*
		Gets the frame colors and duration (in seconds) for a `Chroma` animation. 
		The `color` is expected to be an array of the expected dimensions for the 
		`deviceType/device`. The `length` parameter is the size of the `color` 
		array. For `EChromaSDKDevice1DEnum` the array size should be `MAX LEDS`. 
		For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` * `MAX 
		COLUMN`. Returns the animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginGetFrame(int animationId, int frameIndex, float* duration, int* colors, int length);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetFrame(int animationId, int frameIndex, float* duration, int[] colors, int length);
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
		EXPORT_API int PluginGetFrameCount(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetFrameCount(int animationId);
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
		EXPORT_API int PluginGetFrameCountName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetFrameCountName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetFrameCountNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetFrameCountNameD(IntPtr path);
	/*
		Get the color of an animation key for the given frame referenced by id.
		EXPORT_API int PluginGetKeyColor(int animationId, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetKeyColor(int animationId, int frameId, int rzkey);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetKeyColorD(const char* path, double frameId, double rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetKeyColorD(IntPtr path, double frameId, double rzkey);
	/*
		Get the color of an animation key for the given frame referenced by name.
		EXPORT_API int PluginGetKeyColorName(const char* path, int frameId, int rzkey);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetKeyColorName(IntPtr path, int frameId, int rzkey);
	/*
		Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		integer upon success. Returns -1 upon failure.
		EXPORT_API int PluginGetMaxColumn(int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetMaxColumn(int device);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetMaxColumnD(double device);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetMaxColumnD(double device);
	/*
		Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		upon success. Returns -1 upon failure.
		EXPORT_API int PluginGetMaxLeds(int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetMaxLeds(int device);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetMaxLedsD(double device);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetMaxLedsD(double device);
	/*
		Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		upon success. Returns -1 upon failure.
		EXPORT_API int PluginGetMaxRow(int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetMaxRow(int device);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetMaxRowD(double device);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetMaxRowD(double device);
	/*
		`PluginGetPlayingAnimationCount` will return the number of playing animations.
		EXPORT_API int PluginGetPlayingAnimationCount();
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetPlayingAnimationCount();
	/*
		`PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		of the playing animation. The `index` is zero-based and less than the number 
		returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		to get the name of the animation.
		EXPORT_API int PluginGetPlayingAnimationId(int index);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetPlayingAnimationId(int index);
	/*
		Get the RGB color given red, green, and blue.
		EXPORT_API int PluginGetRGB(int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetRGB(int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginGetRGBD(double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetRGBD(double red, double green, double blue);
	/*
		Check if the animation has loop enabled referenced by id.
		EXPORT_API bool PluginHasAnimationLoop(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginHasAnimationLoop(int animationId);
	/*
		Check if the animation has loop enabled referenced by name.
		EXPORT_API bool PluginHasAnimationLoopName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginHasAnimationLoopName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginHasAnimationLoopNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginHasAnimationLoopNameD(IntPtr path);
	/*
		Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		API methods auto initialize the ChromaSDK if not already initialized.
		EXPORT_API int PluginInit();
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginInit();
	/*
		D suffix for limited data types.
		EXPORT_API double PluginInitD();
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInitD();
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by id.
		EXPORT_API void PluginInsertDelay(int animationId, int frameId, int delay);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertDelay(int animationId, int frameId, int delay);
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by name.
		EXPORT_API void PluginInsertDelayName(const char* path, int frameId, int delay);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertDelayName(IntPtr path, int frameId, int delay);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginInsertDelayNameD(const char* path, double frameId, double delay);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInsertDelayNameD(IntPtr path, double frameId, double delay);
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by id.
		EXPORT_API void PluginInsertFrame(int animationId, int sourceFrame, int targetFrame);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertFrame(int animationId, int sourceFrame, int targetFrame);
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by name.
		EXPORT_API void PluginInsertFrameName(const char* path, int sourceFrame, int targetFrame);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertFrameName(IntPtr path, int sourceFrame, int targetFrame);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginInsertFrameNameD(const char* path, double sourceFrame, double targetFrame);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInsertFrameNameD(IntPtr path, double sourceFrame, double targetFrame);
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		id.
		EXPORT_API void PluginInvertColors(int animationId, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColors(int animationId, int frameId);
	/*
		Invert all the colors for all frames. Animation is referenced by id.
		EXPORT_API void PluginInvertColorsAllFrames(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColorsAllFrames(int animationId);
	/*
		Invert all the colors for all frames. Animation is referenced by name.
		EXPORT_API void PluginInvertColorsAllFramesName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColorsAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginInvertColorsAllFramesNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInvertColorsAllFramesNameD(IntPtr path);
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		name.
		EXPORT_API void PluginInvertColorsName(const char* path, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColorsName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginInvertColorsNameD(const char* path, double frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInvertColorsNameD(IntPtr path, double frameId);
	/*
		Check if the animation is paused referenced by id.
		EXPORT_API bool PluginIsAnimationPaused(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsAnimationPaused(int animationId);
	/*
		Check if the animation is paused referenced by name.
		EXPORT_API bool PluginIsAnimationPausedName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsAnimationPausedName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginIsAnimationPausedNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsAnimationPausedNameD(IntPtr path);
	/*
		The editor dialog is a non-blocking modal window, this method returns true 
		if the modal window is open, otherwise false.
		EXPORT_API bool PluginIsDialogOpen();
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsDialogOpen();
	/*
		D suffix for limited data types.
		EXPORT_API double PluginIsDialogOpenD();
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsDialogOpenD();
	/*
		Returns true if the plugin has been initialized. Returns false if the plugin 
		is uninitialized.
		EXPORT_API bool PluginIsInitialized();
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsInitialized();
	/*
		D suffix for limited data types.
		EXPORT_API double PluginIsInitializedD();
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsInitializedD();
	/*
		If the method can be invoked the method returns true.
		EXPORT_API bool PluginIsPlatformSupported();
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlatformSupported();
	/*
		D suffix for limited data types.
		EXPORT_API double PluginIsPlatformSupportedD();
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlatformSupportedD();
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by id.
		EXPORT_API bool PluginIsPlaying(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlaying(int animationId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginIsPlayingD(double animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlayingD(double animationId);
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by name.
		EXPORT_API bool PluginIsPlayingName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlayingName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginIsPlayingNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlayingNameD(IntPtr path);
	/*
		`PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		the method will return true, otherwise false.
		EXPORT_API bool PluginIsPlayingType(int deviceType, int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlayingType(int deviceType, int device);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginIsPlayingTypeD(double deviceType, double device);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlayingTypeD(double deviceType, double device);
	/*
		Do a lerp math operation on a float.
		EXPORT_API float PluginLerp(float start, float end, float amt);
	*/
	[DllImport(DLL_NAME)]
	private static extern float PluginLerp(float start, float end, float amt);
	/*
		Lerp from one color to another given t in the range 0.0 to 1.0.
		EXPORT_API int PluginLerpColor(int from, int to, float t);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginLerpColor(int from, int to, float t);
	/*
		Loads `Chroma` effects so that the animation can be played immediately. 
		Returns the animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginLoadAnimation(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginLoadAnimation(int animationId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginLoadAnimationD(double animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginLoadAnimationD(double animationId);
	/*
		Load the named animation.
		EXPORT_API void PluginLoadAnimationName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginLoadAnimationName(IntPtr path);
	/*
		Load a composite set of animations.
		EXPORT_API void PluginLoadComposite(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginLoadComposite(IntPtr name);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
		EXPORT_API void PluginMakeBlankFrames(int animationId, int frameCount, float duration, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFrames(int animationId, int frameCount, float duration, int color);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
		EXPORT_API void PluginMakeBlankFramesName(const char* path, int frameCount, float duration, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesName(IntPtr path, int frameCount, float duration, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMakeBlankFramesNameD(const char* path, double frameCount, double duration, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesNameD(IntPtr path, double frameCount, double duration, double color);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by id.
		EXPORT_API void PluginMakeBlankFramesRandom(int animationId, int frameCount, float duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandom(int animationId, int frameCount, float duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by id.
		EXPORT_API void PluginMakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by name.
		EXPORT_API void PluginMakeBlankFramesRandomBlackAndWhiteName(const char* path, int frameCount, float duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandomBlackAndWhiteName(IntPtr path, int frameCount, float duration);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMakeBlankFramesRandomBlackAndWhiteNameD(const char* path, double frameCount, double duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesRandomBlackAndWhiteNameD(IntPtr path, double frameCount, double duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by name.
		EXPORT_API void PluginMakeBlankFramesRandomName(const char* path, int frameCount, float duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandomName(IntPtr path, int frameCount, float duration);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMakeBlankFramesRandomNameD(const char* path, double frameCount, double duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesRandomNameD(IntPtr path, double frameCount, double duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
		EXPORT_API void PluginMakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
		EXPORT_API void PluginMakeBlankFramesRGBName(const char* path, int frameCount, float duration, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRGBName(IntPtr path, int frameCount, float duration, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMakeBlankFramesRGBNameD(const char* path, double frameCount, double duration, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesRGBNameD(IntPtr path, double frameCount, double duration, double red, double green, double blue);
	/*
		Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		the animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginMirrorHorizontally(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginMirrorHorizontally(int animationId);
	/*
		Flips the color grid vertically for all `Chroma` animation frames. This 
		method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginMirrorVertically(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginMirrorVertically(int animationId);
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in id.
		EXPORT_API void PluginMultiplyColorLerpAllFrames(int animationId, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyColorLerpAllFrames(int animationId, int color1, int color2);
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in name.
		EXPORT_API void PluginMultiplyColorLerpAllFramesName(const char* path, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyColorLerpAllFramesName(IntPtr path, int color1, int color2);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyColorLerpAllFramesNameD(const char* path, double color1, double color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
		EXPORT_API void PluginMultiplyIntensity(int animationId, int frameId, float intensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensity(int animationId, int frameId, float intensity);
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
		EXPORT_API void PluginMultiplyIntensityAllFrames(int animationId, float intensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFrames(int animationId, float intensity);
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
		EXPORT_API void PluginMultiplyIntensityAllFramesName(const char* path, float intensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFramesName(IntPtr path, float intensity);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyIntensityAllFramesNameD(const char* path, double intensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityAllFramesNameD(IntPtr path, double intensity);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
		EXPORT_API void PluginMultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
		EXPORT_API void PluginMultiplyIntensityAllFramesRGBName(const char* path, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyIntensityAllFramesRGBNameD(const char* path, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
		EXPORT_API void PluginMultiplyIntensityColor(int animationId, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColor(int animationId, int frameId, int color);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
		EXPORT_API void PluginMultiplyIntensityColorAllFrames(int animationId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColorAllFrames(int animationId, int color);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
		EXPORT_API void PluginMultiplyIntensityColorAllFramesName(const char* path, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyIntensityColorAllFramesNameD(const char* path, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityColorAllFramesNameD(IntPtr path, double color);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
		EXPORT_API void PluginMultiplyIntensityColorName(const char* path, int frameId, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyIntensityColorNameD(const char* path, double frameId, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityColorNameD(IntPtr path, double frameId, double color);
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
		EXPORT_API void PluginMultiplyIntensityName(const char* path, int frameId, float intensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityName(IntPtr path, int frameId, float intensity);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyIntensityNameD(const char* path, double frameId, double intensity);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityNameD(IntPtr path, double frameId, double intensity);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
		EXPORT_API void PluginMultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
		EXPORT_API void PluginMultiplyIntensityRGBName(const char* path, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyIntensityRGBNameD(const char* path, double frameId, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
		EXPORT_API void PluginMultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
		EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
		EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesName(const char* path, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesName(IntPtr path, int color1, int color2);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(const char* path, double color1, double color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		id.
		EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		name.
		EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(const char* path, int red1, int green1, int blue1, int red2, int green2, int blue2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(IntPtr path, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(const char* path, double red1, double green1, double blue1, double red2, double green2, double blue2);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(IntPtr path, double red1, double green1, double blue1, double red2, double green2, double blue2);
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
		EXPORT_API void PluginMultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
		EXPORT_API void PluginMultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
		EXPORT_API void PluginMultiplyTargetColorLerpAllFramesName(const char* path, int color1, int color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFramesName(IntPtr path, int color1, int color2);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyTargetColorLerpAllFramesNameD(const char* path, double color1, double color2);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyTargetColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by id.
		EXPORT_API void PluginMultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by name.
		EXPORT_API void PluginMultiplyTargetColorLerpAllFramesRGBName(const char* path, int red1, int green1, int blue1, int red2, int green2, int blue2);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFramesRGBName(IntPtr path, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginMultiplyTargetColorLerpAllFramesRGBNameD(const char* path, double red1, double green1, double blue1, double red2, double green2, double blue2);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyTargetColorLerpAllFramesRGBNameD(IntPtr path, double red1, double green1, double blue1, double red2, double green2, double blue2);
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
		EXPORT_API void PluginOffsetColors(int animationId, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColors(int animationId, int frameId, int red, int green, int blue);
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
		EXPORT_API void PluginOffsetColorsAllFrames(int animationId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColorsAllFrames(int animationId, int red, int green, int blue);
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
		EXPORT_API void PluginOffsetColorsAllFramesName(const char* path, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColorsAllFramesName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOffsetColorsAllFramesNameD(const char* path, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetColorsAllFramesNameD(IntPtr path, double red, double green, double blue);
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
		EXPORT_API void PluginOffsetColorsName(const char* path, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColorsName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOffsetColorsNameD(const char* path, double frameId, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetColorsNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
		EXPORT_API void PluginOffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
		EXPORT_API void PluginOffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
		EXPORT_API void PluginOffsetNonZeroColorsAllFramesName(const char* path, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColorsAllFramesName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOffsetNonZeroColorsAllFramesNameD(const char* path, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetNonZeroColorsAllFramesNameD(IntPtr path, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
		EXPORT_API void PluginOffsetNonZeroColorsName(const char* path, int frameId, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColorsName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOffsetNonZeroColorsNameD(const char* path, double frameId, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetNonZeroColorsNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Opens a `Chroma` animation file so that it can be played. Returns an animation 
		id >= 0 upon success. Returns -1 if there was a failure. The animation 
		id is used in most of the API methods.
		EXPORT_API int PluginOpenAnimation(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOpenAnimation(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOpenAnimationD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOpenAnimationD(IntPtr path);
	/*
		Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		upon success. Returns -1 if there was a failure.
		EXPORT_API int PluginOpenEditorDialog(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOpenEditorDialog(IntPtr path);
	/*
		Open the named animation in the editor dialog and play the animation at 
		start.
		EXPORT_API int PluginOpenEditorDialogAndPlay(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOpenEditorDialogAndPlay(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOpenEditorDialogAndPlayD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOpenEditorDialogAndPlayD(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOpenEditorDialogD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOpenEditorDialogD(IntPtr path);
	/*
		Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		parameter. Returns the animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginOverrideFrameDuration(int animationId, float duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOverrideFrameDuration(int animationId, float duration);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginOverrideFrameDurationD(double animationId, double duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOverrideFrameDurationD(double animationId, double duration);
	/*
		Override the duration of all frames with the `duration` value. Animation 
		is referenced by name.
		EXPORT_API void PluginOverrideFrameDurationName(const char* path, float duration);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOverrideFrameDurationName(IntPtr path, float duration);
	/*
		Pause the current animation referenced by id.
		EXPORT_API void PluginPauseAnimation(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPauseAnimation(int animationId);
	/*
		Pause the current animation referenced by name.
		EXPORT_API void PluginPauseAnimationName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPauseAnimationName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginPauseAnimationNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPauseAnimationNameD(IntPtr path);
	/*
		Plays the `Chroma` animation. This will load the animation, if not loaded 
		previously. Returns the animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginPlayAnimation(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginPlayAnimation(int animationId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginPlayAnimationD(double animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayAnimationD(double animationId);
	/*
		`PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off` starting at the `frameId`.
		EXPORT_API void PluginPlayAnimationFrame(int animationId, int frameId, bool loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationFrame(int animationId, int frameId, bool loop);
	/*
		`PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off` starting at the `frameId`.
		EXPORT_API void PluginPlayAnimationFrameName(const char* path, int frameId, bool loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationFrameName(IntPtr path, int frameId, bool loop);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginPlayAnimationFrameNameD(const char* path, double frameId, double loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayAnimationFrameNameD(IntPtr path, double frameId, double loop);
	/*
		`PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off`.
		EXPORT_API void PluginPlayAnimationLoop(int animationId, bool loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationLoop(int animationId, bool loop);
	/*
		`PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off`.
		EXPORT_API void PluginPlayAnimationName(const char* path, bool loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationName(IntPtr path, bool loop);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginPlayAnimationNameD(const char* path, double loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayAnimationNameD(IntPtr path, double loop);
	/*
		`PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will play with looping `on` or `off`.
		EXPORT_API void PluginPlayComposite(const char* name, bool loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayComposite(IntPtr name, bool loop);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginPlayCompositeD(const char* name, double loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayCompositeD(IntPtr name, double loop);
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Returns the animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginPreviewFrame(int animationId, int frameIndex);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginPreviewFrame(int animationId, int frameIndex);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginPreviewFrameD(double animationId, double frameIndex);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPreviewFrameD(double animationId, double frameIndex);
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Animaton is referenced by name.
		EXPORT_API void PluginPreviewFrameName(const char* path, int frameIndex);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPreviewFrameName(IntPtr path, int frameIndex);
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by id.
		EXPORT_API void PluginReduceFrames(int animationId, int n);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReduceFrames(int animationId, int n);
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by name.
		EXPORT_API void PluginReduceFramesName(const char* path, int n);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReduceFramesName(IntPtr path, int n);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginReduceFramesNameD(const char* path, double n);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginReduceFramesNameD(IntPtr path, double n);
	/*
		Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		upon success. Returns -1 upon failure.
		EXPORT_API int PluginResetAnimation(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginResetAnimation(int animationId);
	/*
		Resume the animation with loop `ON` or `OFF` referenced by id.
		EXPORT_API void PluginResumeAnimation(int animationId, bool loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginResumeAnimation(int animationId, bool loop);
	/*
		Resume the animation with loop `ON` or `OFF` referenced by name.
		EXPORT_API void PluginResumeAnimationName(const char* path, bool loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginResumeAnimationName(IntPtr path, bool loop);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginResumeAnimationNameD(const char* path, double loop);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginResumeAnimationNameD(IntPtr path, double loop);
	/*
		Reverse the animation frame order of the `Chroma` animation. Returns the 
		animation id upon success. Returns -1 upon failure. Animation is referenced 
		by id.
		EXPORT_API int PluginReverse(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginReverse(int animationId);
	/*
		Reverse the animation frame order of the `Chroma` animation. Animation is 
		referenced by id.
		EXPORT_API void PluginReverseAllFrames(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReverseAllFrames(int animationId);
	/*
		Reverse the animation frame order of the `Chroma` animation. Animation is 
		referenced by name.
		EXPORT_API void PluginReverseAllFramesName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReverseAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginReverseAllFramesNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginReverseAllFramesNameD(IntPtr path);
	/*
		Save the animation referenced by id to the path specified.
		EXPORT_API int PluginSaveAnimation(int animationId, const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSaveAnimation(int animationId, IntPtr path);
	/*
		Save the named animation to the target path specified.
		EXPORT_API int PluginSaveAnimationName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSaveAnimationName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by id.
		EXPORT_API void PluginSet1DColor(int animationId, int frameId, int led, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet1DColor(int animationId, int frameId, int led, int color);
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by name.
		EXPORT_API void PluginSet1DColorName(const char* path, int frameId, int led, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet1DColorName(IntPtr path, int frameId, int led, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSet1DColorNameD(const char* path, double frameId, double led, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSet1DColorNameD(IntPtr path, double frameId, double led, double color);
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by id.
		EXPORT_API void PluginSet2DColor(int animationId, int frameId, int row, int column, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet2DColor(int animationId, int frameId, int row, int column, int color);
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by name.
		EXPORT_API void PluginSet2DColorName(const char* path, int frameId, int row, int column, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet2DColorName(IntPtr path, int frameId, int row, int column, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSet2DColorNameD(const char* path, double frameId, double rowColumnIndex, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSet2DColorNameD(IntPtr path, double frameId, double rowColumnIndex, double color);
	/*
		When custom color is set, the custom key mode will be used. The animation 
		is referenced by id.
		EXPORT_API void PluginSetChromaCustomColorAllFrames(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomColorAllFrames(int animationId);
	/*
		When custom color is set, the custom key mode will be used. The animation 
		is referenced by name.
		EXPORT_API void PluginSetChromaCustomColorAllFramesName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomColorAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetChromaCustomColorAllFramesNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetChromaCustomColorAllFramesNameD(IntPtr path);
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by id.
		EXPORT_API void PluginSetChromaCustomFlag(int animationId, bool flag);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomFlag(int animationId, bool flag);
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by name.
		EXPORT_API void PluginSetChromaCustomFlagName(const char* path, bool flag);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomFlagName(IntPtr path, bool flag);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetChromaCustomFlagNameD(const char* path, double flag);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetChromaCustomFlagNameD(IntPtr path, double flag);
	/*
		Set the current frame of the animation referenced by id.
		EXPORT_API void PluginSetCurrentFrame(int animationId, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetCurrentFrame(int animationId, int frameId);
	/*
		Set the current frame of the animation referenced by name.
		EXPORT_API void PluginSetCurrentFrameName(const char* path, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetCurrentFrameName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetCurrentFrameNameD(const char* path, double frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetCurrentFrameNameD(IntPtr path, double frameId);
	/*
		Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		the animation id upon success. Returns -1 upon failure.
		EXPORT_API int PluginSetDevice(int animationId, int deviceType, int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSetDevice(int animationId, int deviceType, int device);
	/*
		SetEffect will display the referenced effect id.
		EXPORT_API RZRESULT PluginSetEffect(const ChromaSDK::FChromaSDKGuid& effectId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSetEffect(System.Guid effectId);
	/*
		Set animation key to a static color for the given frame.
		EXPORT_API void PluginSetKeyColor(int animationId, int frameId, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColor(int animationId, int frameId, int rzkey, int color);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
		EXPORT_API void PluginSetKeyColorAllFrames(int animationId, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFrames(int animationId, int rzkey, int color);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
		EXPORT_API void PluginSetKeyColorAllFramesName(const char* path, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFramesName(IntPtr path, int rzkey, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyColorAllFramesNameD(const char* path, double rzkey, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorAllFramesNameD(IntPtr path, double rzkey, double color);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
		EXPORT_API void PluginSetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
		EXPORT_API void PluginSetKeyColorAllFramesRGBName(const char* path, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFramesRGBName(IntPtr path, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyColorAllFramesRGBNameD(const char* path, double rzkey, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorAllFramesRGBNameD(IntPtr path, double rzkey, double red, double green, double blue);
	/*
		Set animation key to a static color for the given frame.
		EXPORT_API void PluginSetKeyColorName(const char* path, int frameId, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorName(IntPtr path, int frameId, int rzkey, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyColorNameD(const char* path, double frameId, double rzkey, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorNameD(IntPtr path, double frameId, double rzkey, double color);
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by id.
		EXPORT_API void PluginSetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by name.
		EXPORT_API void PluginSetKeyColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
		EXPORT_API void PluginSetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color);
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
		EXPORT_API void PluginSetKeyNonZeroColorName(const char* path, int frameId, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColorName(IntPtr path, int frameId, int rzkey, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyNonZeroColorNameD(const char* path, double frameId, double rzkey, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyNonZeroColorNameD(IntPtr path, double frameId, double rzkey, double color);
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by id.
		EXPORT_API void PluginSetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by name.
		EXPORT_API void PluginSetKeyNonZeroColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyNonZeroColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyNonZeroColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
		EXPORT_API void PluginSetKeysColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
		EXPORT_API void PluginSetKeysColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
		EXPORT_API void PluginSetKeysColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
		EXPORT_API void PluginSetKeysColorAllFramesRGB(int animationId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
		EXPORT_API void PluginSetKeysColorAllFramesRGBName(const char* path, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFramesRGBName(IntPtr path, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame.
		EXPORT_API void PluginSetKeysColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
		EXPORT_API void PluginSetKeysColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by name.
		EXPORT_API void PluginSetKeysColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black.
		EXPORT_API void PluginSetKeysNonZeroColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
		EXPORT_API void PluginSetKeysNonZeroColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames if the existing 
		color is not already black. Reference animation by name.
		EXPORT_API void PluginSetKeysNonZeroColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black. Reference animation by name.
		EXPORT_API void PluginSetKeysNonZeroColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
		EXPORT_API void PluginSetKeysNonZeroColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by name.
		EXPORT_API void PluginSetKeysNonZeroColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
		EXPORT_API void PluginSetKeysZeroColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
		EXPORT_API void PluginSetKeysZeroColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
		EXPORT_API void PluginSetKeysZeroColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
		EXPORT_API void PluginSetKeysZeroColorAllFramesRGB(int animationId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
		EXPORT_API void PluginSetKeysZeroColorAllFramesRGBName(const char* path, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFramesRGBName(IntPtr path, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
		EXPORT_API void PluginSetKeysZeroColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
		EXPORT_API void PluginSetKeysZeroColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
		EXPORT_API void PluginSetKeysZeroColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
		EXPORT_API void PluginSetKeyZeroColor(int animationId, int frameId, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColor(int animationId, int frameId, int rzkey, int color);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
		EXPORT_API void PluginSetKeyZeroColorName(const char* path, int frameId, int rzkey, int color);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColorName(IntPtr path, int frameId, int rzkey, int color);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyZeroColorNameD(const char* path, double frameId, double rzkey, double color);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyZeroColorNameD(IntPtr path, double frameId, double rzkey, double color);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
		EXPORT_API void PluginSetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
		EXPORT_API void PluginSetKeyZeroColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSetKeyZeroColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyZeroColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
	/*
		Invokes the setup for a debug logging callback so that `stdout` is redirected 
		to the callback. This is used by `Unity` so that debug messages can appear 
		in the console window.
		EXPORT_API void PluginSetLogDelegate(DebugLogPtr fp);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetLogDelegate(DebugLogPtr fp);
	/*
		`PluginStopAll` will automatically stop all animations that are playing.
		EXPORT_API void PluginStopAll();
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopAll();
	/*
		Stops animation playback if in progress. Returns the animation id upon success. 
		Returns -1 upon failure.
		EXPORT_API int PluginStopAnimation(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginStopAnimation(int animationId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginStopAnimationD(double animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopAnimationD(double animationId);
	/*
		`PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will stop if playing.
		EXPORT_API void PluginStopAnimationName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopAnimationName(IntPtr path);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginStopAnimationNameD(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopAnimationNameD(IntPtr path);
	/*
		`PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		it will be stopped.
		EXPORT_API void PluginStopAnimationType(int deviceType, int device);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopAnimationType(int deviceType, int device);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginStopAnimationTypeD(double deviceType, double device);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopAnimationTypeD(double deviceType, double device);
	/*
		`PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will be stopped if playing.
		EXPORT_API void PluginStopComposite(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopComposite(IntPtr name);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginStopCompositeD(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopCompositeD(IntPtr name);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by id.
		EXPORT_API void PluginSubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by name.
		EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSubtractNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by id.
		EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by name.
		EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by id.
		EXPORT_API void PluginSubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by name.
		EXPORT_API void PluginSubtractNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSubtractNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by id.
		EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by name.
		EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSubtractNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by id.
		EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by name.
		EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by id.
		EXPORT_API void PluginSubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by name.
		EXPORT_API void PluginSubtractNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginSubtractNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by id.
		EXPORT_API void PluginTrimEndFrames(int animationId, int lastFrameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimEndFrames(int animationId, int lastFrameId);
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by name.
		EXPORT_API void PluginTrimEndFramesName(const char* path, int lastFrameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimEndFramesName(IntPtr path, int lastFrameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginTrimEndFramesNameD(const char* path, double lastFrameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginTrimEndFramesNameD(IntPtr path, double lastFrameId);
	/*
		Remove the frame from the animation. Reference animation by id.
		EXPORT_API void PluginTrimFrame(int animationId, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimFrame(int animationId, int frameId);
	/*
		Remove the frame from the animation. Reference animation by name.
		EXPORT_API void PluginTrimFrameName(const char* path, int frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimFrameName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginTrimFrameNameD(const char* path, double frameId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginTrimFrameNameD(IntPtr path, double frameId);
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by id.
		EXPORT_API void PluginTrimStartFrames(int animationId, int numberOfFrames);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimStartFrames(int animationId, int numberOfFrames);
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by name.
		EXPORT_API void PluginTrimStartFramesName(const char* path, int numberOfFrames);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimStartFramesName(IntPtr path, int numberOfFrames);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginTrimStartFramesNameD(const char* path, double numberOfFrames);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginTrimStartFramesNameD(IntPtr path, double numberOfFrames);
	/*
		Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns -1 upon failure.
		EXPORT_API int PluginUninit();
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginUninit();
	/*
		D suffix for limited data types.
		EXPORT_API double PluginUninitD();
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginUninitD();
	/*
		Unloads `Chroma` effects to free up resources. Returns the animation id 
		upon success. Returns -1 upon failure. Reference the animation by id.
		EXPORT_API int PluginUnloadAnimation(int animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginUnloadAnimation(int animationId);
	/*
		D suffix for limited data types.
		EXPORT_API double PluginUnloadAnimationD(double animationId);
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginUnloadAnimationD(double animationId);
	/*
		Unload the animation effects. Reference the animation by name.
		EXPORT_API void PluginUnloadAnimationName(const char* path);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginUnloadAnimationName(IntPtr path);
	/*
		Unload the the composite set of animation effects. Reference the animation 
		by name.
		EXPORT_API void PluginUnloadComposite(const char* name);
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginUnloadComposite(IntPtr name);
	/*
		Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		(in seconds). The `color` is expected to be an array of the dimensions 
		for the `deviceType/device`. The `length` parameter is the size of the 
		`color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		* `MAX COLUMN`. Returns the animation id upon success. Returns -1 upon 
		failure.
		EXPORT_API int PluginUpdateFrame(int animationId, int frameIndex, float duration, int* colors, int length);
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginUpdateFrame(int animationId, int frameIndex, float duration, int[] colors, int length);
#endregion
