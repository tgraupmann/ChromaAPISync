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
		return PluginAddFrame(animationId,duration,colors,length);
	}
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by id.
	*/
	public static void AddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginAddNonZeroAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by name.
	*/
	public static void AddNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginAddNonZeroAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginAddNonZeroAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		id.
	*/
	public static void AddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginAddNonZeroAllKeysAllFramesOffset(sourceAnimationId,targetAnimationId,offset);
	}
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		name.
	*/
	public static void AddNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		PluginAddNonZeroAllKeysAllFramesOffsetName(sourceAnimation,targetAnimation,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		return PluginAddNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation,targetAnimation,offset);
	}
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by id.
	*/
	public static void AddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginAddNonZeroAllKeysOffset(sourceAnimationId,targetAnimationId,frameId,offset);
	}
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by name.
	*/
	public static void AddNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		PluginAddNonZeroAllKeysOffsetName(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		return PluginAddNonZeroAllKeysOffsetNameD(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by id.
	*/
	public static void AddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginAddNonZeroTargetAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by name.
	*/
	public static void AddNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginAddNonZeroTargetAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginAddNonZeroTargetAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by id.
	*/
	public static void AddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginAddNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId,targetAnimationId,offset);
	}
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by name.
	*/
	public static void AddNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		PluginAddNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation,targetAnimation,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		return PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation,targetAnimation,offset);
	}
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by id.
	*/
	public static void AddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginAddNonZeroTargetAllKeysOffset(sourceAnimationId,targetAnimationId,frameId,offset);
	}
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by name.
	*/
	public static void AddNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		PluginAddNonZeroTargetAllKeysOffsetName(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AddNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		return PluginAddNonZeroTargetAllKeysOffsetNameD(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		Append all source frames to the target animation, reference source and target 
		by id.
	*/
	public static void AppendAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginAppendAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Append all source frames to the target animation, reference source and target 
		by name.
	*/
	public static void AppendAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginAppendAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double AppendAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginAppendAllFramesNameD(sourceAnimation,targetAnimation);
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
		PluginClearAnimationType(deviceType,device);
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
		return PluginCloseAnimation(animationId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CloseAnimationD(double animationId)
	{
		return PluginCloseAnimationD(animationId);
	}
	/*
		Closes the `Chroma` animation referenced by name so that the animation can 
		be reloaded from disk.
	*/
	public static void CloseAnimationName(string path)
	{
		PluginCloseAnimationName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CloseAnimationNameD(string path)
	{
		return PluginCloseAnimationNameD(path);
	}
	/*
		`PluginCloseComposite` closes a set of animations so they can be reloaded 
		from disk. The set of animations will be stopped if playing.
	*/
	public static void CloseComposite(string name)
	{
		PluginCloseComposite(name);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CloseCompositeD(string name)
	{
		return PluginCloseCompositeD(name);
	}
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by id.
	*/
	public static int CopyAnimation(int sourceAnimationId, string targetAnimation)
	{
		return PluginCopyAnimation(sourceAnimationId,targetAnimation);
	}
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by name.
	*/
	public static void CopyAnimationName(string sourceAnimation, string targetAnimation)
	{
		PluginCopyAnimationName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyAnimationNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginCopyAnimationNameD(sourceAnimation,targetAnimation);
	}
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
	*/
	public static void CopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity)
	{
		PluginCopyBlueChannelAllFrames(animationId,redIntensity,greenIntensity);
	}
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by name.
	*/
	public static void CopyBlueChannelAllFramesName(string path, float redIntensity, float greenIntensity)
	{
		PluginCopyBlueChannelAllFramesName(path,redIntensity,greenIntensity);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyBlueChannelAllFramesNameD(string path, double redIntensity, double greenIntensity)
	{
		return PluginCopyBlueChannelAllFramesNameD(path,redIntensity,greenIntensity);
	}
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by id.
	*/
	public static void CopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity)
	{
		PluginCopyGreenChannelAllFrames(animationId,redIntensity,blueIntensity);
	}
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
	*/
	public static void CopyGreenChannelAllFramesName(string path, float redIntensity, float blueIntensity)
	{
		PluginCopyGreenChannelAllFramesName(path,redIntensity,blueIntensity);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyGreenChannelAllFramesNameD(string path, double redIntensity, double blueIntensity)
	{
		return PluginCopyGreenChannelAllFramesNameD(path,redIntensity,blueIntensity);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame. Reference the source and target by id.
	*/
	public static void CopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
	{
		PluginCopyKeyColor(sourceAnimationId,targetAnimationId,frameId,rzkey);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by id.
	*/
	public static void CopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey)
	{
		PluginCopyKeyColorAllFrames(sourceAnimationId,targetAnimationId,rzkey);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by name.
	*/
	public static void CopyKeyColorAllFramesName(string sourceAnimation, string targetAnimation, int rzkey)
	{
		PluginCopyKeyColorAllFramesName(sourceAnimation,targetAnimation,rzkey);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyKeyColorAllFramesNameD(string sourceAnimation, string targetAnimation, double rzkey)
	{
		return PluginCopyKeyColorAllFramesNameD(sourceAnimation,targetAnimation,rzkey);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by id.
	*/
	public static void CopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset)
	{
		PluginCopyKeyColorAllFramesOffset(sourceAnimationId,targetAnimationId,rzkey,offset);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by name.
	*/
	public static void CopyKeyColorAllFramesOffsetName(string sourceAnimation, string targetAnimation, int rzkey, int offset)
	{
		PluginCopyKeyColorAllFramesOffsetName(sourceAnimation,targetAnimation,rzkey,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyKeyColorAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double rzkey, double offset)
	{
		return PluginCopyKeyColorAllFramesOffsetNameD(sourceAnimation,targetAnimation,rzkey,offset);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame.
	*/
	public static void CopyKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
	{
		PluginCopyKeyColorName(sourceAnimation,targetAnimation,frameId,rzkey);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
	{
		return PluginCopyKeyColorNameD(sourceAnimation,targetAnimation,frameId,rzkey);
	}
	/*
		Copy source animation to target animation for the given frame. Source and 
		target are referenced by id.
	*/
	public static void CopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
	{
		PluginCopyNonZeroAllKeys(sourceAnimationId,targetAnimationId,frameId);
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by id.
	*/
	public static void CopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyNonZeroAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by name.
	*/
	public static void CopyNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginCopyNonZeroAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginCopyNonZeroAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by id.
	*/
	public static void CopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginCopyNonZeroAllKeysAllFramesOffset(sourceAnimationId,targetAnimationId,offset);
	}
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by name.
	*/
	public static void CopyNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		PluginCopyNonZeroAllKeysAllFramesOffsetName(sourceAnimation,targetAnimation,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		return PluginCopyNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation,targetAnimation,offset);
	}
	/*
		Copy nonzero colors from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
	*/
	public static void CopyNonZeroAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
	{
		PluginCopyNonZeroAllKeysName(sourceAnimation,targetAnimation,frameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysNameD(string sourceAnimation, string targetAnimation, double frameId)
	{
		return PluginCopyNonZeroAllKeysNameD(sourceAnimation,targetAnimation,frameId);
	}
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by id.
	*/
	public static void CopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginCopyNonZeroAllKeysOffset(sourceAnimationId,targetAnimationId,frameId,offset);
	}
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by name.
	*/
	public static void CopyNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		PluginCopyNonZeroAllKeysOffsetName(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		return PluginCopyNonZeroAllKeysOffsetNameD(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
	*/
	public static void CopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
	{
		PluginCopyNonZeroKeyColor(sourceAnimationId,targetAnimationId,frameId,rzkey);
	}
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
	*/
	public static void CopyNonZeroKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
	{
		PluginCopyNonZeroKeyColorName(sourceAnimation,targetAnimation,frameId,rzkey);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
	{
		return PluginCopyNonZeroKeyColorNameD(sourceAnimation,targetAnimation,frameId,rzkey);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. Source and target 
		are referenced by id.
	*/
	public static void CopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
	{
		PluginCopyNonZeroTargetAllKeys(sourceAnimationId,targetAnimationId,frameId);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by id.
	*/
	public static void CopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyNonZeroTargetAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
	*/
	public static void CopyNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginCopyNonZeroTargetAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginCopyNonZeroTargetAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
	*/
	public static void CopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginCopyNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId,targetAnimationId,offset);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames starting at the target offset 
		for the length of the source animation. Source and target animations are 
		referenced by name.
	*/
	public static void CopyNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation,targetAnimation,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		return PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation,targetAnimation,offset);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. The source and target 
		are referenced by name.
	*/
	public static void CopyNonZeroTargetAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
	{
		PluginCopyNonZeroTargetAllKeysName(sourceAnimation,targetAnimation,frameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysNameD(string sourceAnimation, string targetAnimation, double frameId)
	{
		return PluginCopyNonZeroTargetAllKeysNameD(sourceAnimation,targetAnimation,frameId);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by id.
	*/
	public static void CopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginCopyNonZeroTargetAllKeysOffset(sourceAnimationId,targetAnimationId,frameId,offset);
	}
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by name.
	*/
	public static void CopyNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		PluginCopyNonZeroTargetAllKeysOffsetName(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		return PluginCopyNonZeroTargetAllKeysOffsetNameD(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		Copy red channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
	*/
	public static void CopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity)
	{
		PluginCopyRedChannelAllFrames(animationId,greenIntensity,blueIntensity);
	}
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
	*/
	public static void CopyRedChannelAllFramesName(string path, float greenIntensity, float blueIntensity)
	{
		PluginCopyRedChannelAllFramesName(path,greenIntensity,blueIntensity);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyRedChannelAllFramesNameD(string path, double greenIntensity, double blueIntensity)
	{
		return PluginCopyRedChannelAllFramesNameD(path,greenIntensity,blueIntensity);
	}
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by id.
	*/
	public static void CopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyZeroAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by name.
	*/
	public static void CopyZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginCopyZeroAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginCopyZeroAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by id.
	*/
	public static void CopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginCopyZeroAllKeysAllFramesOffset(sourceAnimationId,targetAnimationId,offset);
	}
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by name.
	*/
	public static void CopyZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		PluginCopyZeroAllKeysAllFramesOffsetName(sourceAnimation,targetAnimation,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		return PluginCopyZeroAllKeysAllFramesOffsetNameD(sourceAnimation,targetAnimation,offset);
	}
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
	*/
	public static void CopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
	{
		PluginCopyZeroKeyColor(sourceAnimationId,targetAnimationId,frameId,rzkey);
	}
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by name.
	*/
	public static void CopyZeroKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
	{
		PluginCopyZeroKeyColorName(sourceAnimation,targetAnimation,frameId,rzkey);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
	{
		return PluginCopyZeroKeyColorNameD(sourceAnimation,targetAnimation,frameId,rzkey);
	}
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by id.
	*/
	public static void CopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginCopyZeroTargetAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by name.
	*/
	public static void CopyZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginCopyZeroTargetAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double CopyZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginCopyZeroTargetAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateChromaLinkEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		return PluginCoreCreateChromaLinkEffect(Effect,pParam,pEffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateEffect(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		return PluginCoreCreateEffect(DeviceId,Effect,pParam,pEffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateHeadsetEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		return PluginCoreCreateHeadsetEffect(Effect,pParam,pEffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateKeyboardEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		return PluginCoreCreateKeyboardEffect(Effect,pParam,pEffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateKeypadEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		return PluginCoreCreateKeypadEffect(Effect,pParam,pEffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateMouseEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		return PluginCoreCreateMouseEffect(Effect,pParam,pEffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreCreateMousepadEffect(int Effect, PRZPARAM pParam, RZEFFECTID* pEffectId)
	{
		return PluginCoreCreateMousepadEffect(Effect,pParam,pEffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreDeleteEffect(RZEFFECTID EffectId)
	{
		return PluginCoreDeleteEffect(EffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreInit()
	{
		return PluginCoreInit();
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreQueryDevice(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE& DeviceInfo)
	{
		return PluginCoreQueryDevice(DeviceId,DeviceInfo);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreSetEffect(RZEFFECTID EffectId)
	{
		return PluginCoreSetEffect(EffectId);
	}
	/*
		Direct access to low level API.
	*/
	public static int CoreUnInit()
	{
		return PluginCoreUnInit();
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
		return PluginCreateAnimation(path,deviceType,device);
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
		return PluginCreateAnimationInMemory(deviceType,device);
	}
	/*
		Create a device specific effect.
	*/
	public static int CreateEffect(RZDEVICEID deviceId, ChromaSDK::EFFECT_TYPE effect, int[] colors, int size, ChromaSDK::FChromaSDKGuid* effectId)
	{
		return PluginCreateEffect(deviceId,effect,colors,size,effectId);
	}
	/*
		Delete an effect given the effect id.
	*/
	public static int DeleteEffect(System.Guid effectId)
	{
		return PluginDeleteEffect(effectId);
	}
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by id.
	*/
	public static void DuplicateFirstFrame(int animationId, int frameCount)
	{
		PluginDuplicateFirstFrame(animationId,frameCount);
	}
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by name.
	*/
	public static void DuplicateFirstFrameName(string path, int frameCount)
	{
		PluginDuplicateFirstFrameName(path,frameCount);
	}
	/*
		D suffix for limited data types.
	*/
	public static double DuplicateFirstFrameNameD(string path, double frameCount)
	{
		return PluginDuplicateFirstFrameNameD(path,frameCount);
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
		PluginDuplicateFramesName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double DuplicateFramesNameD(string path)
	{
		return PluginDuplicateFramesNameD(path);
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
		PluginDuplicateMirrorFramesName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double DuplicateMirrorFramesNameD(string path)
	{
		return PluginDuplicateMirrorFramesNameD(path);
	}
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by id.
	*/
	public static void FadeEndFrames(int animationId, int fade)
	{
		PluginFadeEndFrames(animationId,fade);
	}
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by name.
	*/
	public static void FadeEndFramesName(string path, int fade)
	{
		PluginFadeEndFramesName(path,fade);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FadeEndFramesNameD(string path, double fade)
	{
		return PluginFadeEndFramesNameD(path,fade);
	}
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by id.
	*/
	public static void FadeStartFrames(int animationId, int fade)
	{
		PluginFadeStartFrames(animationId,fade);
	}
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by name.
	*/
	public static void FadeStartFramesName(string path, int fade)
	{
		PluginFadeStartFramesName(path,fade);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FadeStartFramesNameD(string path, double fade)
	{
		return PluginFadeStartFramesNameD(path,fade);
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
	*/
	public static void FillColor(int animationId, int frameId, int color)
	{
		PluginFillColor(animationId,frameId,color);
	}
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by id.
	*/
	public static void FillColorAllFrames(int animationId, int color)
	{
		PluginFillColorAllFrames(animationId,color);
	}
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by name.
	*/
	public static void FillColorAllFramesName(string path, int color)
	{
		PluginFillColorAllFramesName(path,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorAllFramesNameD(string path, double color)
	{
		return PluginFillColorAllFramesNameD(path,color);
	}
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by id.
	*/
	public static void FillColorAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginFillColorAllFramesRGB(animationId,red,green,blue);
	}
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by name.
	*/
	public static void FillColorAllFramesRGBName(string path, int red, int green, int blue)
	{
		PluginFillColorAllFramesRGBName(path,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		return PluginFillColorAllFramesRGBNameD(path,red,green,blue);
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
	*/
	public static void FillColorName(string path, int frameId, int color)
	{
		PluginFillColorName(path,frameId,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorNameD(string path, double frameId, double color)
	{
		return PluginFillColorNameD(path,frameId,color);
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
	*/
	public static void FillColorRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginFillColorRGB(animationId,frameId,red,green,blue);
	}
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
	*/
	public static void FillColorRGBName(string path, int frameId, int red, int green, int blue)
	{
		PluginFillColorRGBName(path,frameId,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillColorRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		return PluginFillColorRGBNameD(path,frameId,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by id.
	*/
	public static void FillNonZeroColor(int animationId, int frameId, int color)
	{
		PluginFillNonZeroColor(animationId,frameId,color);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by id.
	*/
	public static void FillNonZeroColorAllFrames(int animationId, int color)
	{
		PluginFillNonZeroColorAllFrames(animationId,color);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by name.
	*/
	public static void FillNonZeroColorAllFramesName(string path, int color)
	{
		PluginFillNonZeroColorAllFramesName(path,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorAllFramesNameD(string path, double color)
	{
		return PluginFillNonZeroColorAllFramesNameD(path,color);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
	*/
	public static void FillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginFillNonZeroColorAllFramesRGB(animationId,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
	*/
	public static void FillNonZeroColorAllFramesRGBName(string path, int red, int green, int blue)
	{
		PluginFillNonZeroColorAllFramesRGBName(path,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		return PluginFillNonZeroColorAllFramesRGBNameD(path,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by name.
	*/
	public static void FillNonZeroColorName(string path, int frameId, int color)
	{
		PluginFillNonZeroColorName(path,frameId,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorNameD(string path, double frameId, double color)
	{
		return PluginFillNonZeroColorNameD(path,frameId,color);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
	*/
	public static void FillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginFillNonZeroColorRGB(animationId,frameId,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
	*/
	public static void FillNonZeroColorRGBName(string path, int frameId, int red, int green, int blue)
	{
		PluginFillNonZeroColorRGBName(path,frameId,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillNonZeroColorRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		return PluginFillNonZeroColorRGBNameD(path,frameId,red,green,blue);
	}
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by id.
	*/
	public static void FillRandomColors(int animationId, int frameId)
	{
		PluginFillRandomColors(animationId,frameId);
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
		PluginFillRandomColorsAllFramesName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsAllFramesNameD(string path)
	{
		return PluginFillRandomColorsAllFramesNameD(path);
	}
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by id.
	*/
	public static void FillRandomColorsBlackAndWhite(int animationId, int frameId)
	{
		PluginFillRandomColorsBlackAndWhite(animationId,frameId);
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
		PluginFillRandomColorsBlackAndWhiteAllFramesName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsBlackAndWhiteAllFramesNameD(string path)
	{
		return PluginFillRandomColorsBlackAndWhiteAllFramesNameD(path);
	}
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by name.
	*/
	public static void FillRandomColorsBlackAndWhiteName(string path, int frameId)
	{
		PluginFillRandomColorsBlackAndWhiteName(path,frameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsBlackAndWhiteNameD(string path, double frameId)
	{
		return PluginFillRandomColorsBlackAndWhiteNameD(path,frameId);
	}
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by name.
	*/
	public static void FillRandomColorsName(string path, int frameId)
	{
		PluginFillRandomColorsName(path,frameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillRandomColorsNameD(string path, double frameId)
	{
		return PluginFillRandomColorsNameD(path,frameId);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColors(int animationId, int frameId, int threshold, int color)
	{
		PluginFillThresholdColors(animationId,frameId,threshold,color);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsAllFrames(int animationId, int threshold, int color)
	{
		PluginFillThresholdColorsAllFrames(animationId,threshold,color);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsAllFramesName(string path, int threshold, int color)
	{
		PluginFillThresholdColorsAllFramesName(path,threshold,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsAllFramesNameD(string path, double threshold, double color)
	{
		return PluginFillThresholdColorsAllFramesNameD(path,threshold,color);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue)
	{
		PluginFillThresholdColorsAllFramesRGB(animationId,threshold,red,green,blue);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsAllFramesRGBName(string path, int threshold, int red, int green, int blue)
	{
		PluginFillThresholdColorsAllFramesRGBName(path,threshold,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsAllFramesRGBNameD(string path, double threshold, double red, double green, double blue)
	{
		return PluginFillThresholdColorsAllFramesRGBNameD(path,threshold,red,green,blue);
	}
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		PluginFillThresholdColorsMinMaxAllFramesRGB(animationId,minThreshold,minRed,minGreen,minBlue,maxThreshold,maxRed,maxGreen,maxBlue);
	}
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsMinMaxAllFramesRGBName(string path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		PluginFillThresholdColorsMinMaxAllFramesRGBName(path,minThreshold,minRed,minGreen,minBlue,maxThreshold,maxRed,maxGreen,maxBlue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsMinMaxAllFramesRGBNameD(string path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue)
	{
		return PluginFillThresholdColorsMinMaxAllFramesRGBNameD(path,minThreshold,minRed,minGreen,minBlue,maxThreshold,maxRed,maxGreen,maxBlue);
	}
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		PluginFillThresholdColorsMinMaxRGB(animationId,frameId,minThreshold,minRed,minGreen,minBlue,maxThreshold,maxRed,maxGreen,maxBlue);
	}
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsMinMaxRGBName(string path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
	{
		PluginFillThresholdColorsMinMaxRGBName(path,frameId,minThreshold,minRed,minGreen,minBlue,maxThreshold,maxRed,maxGreen,maxBlue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsMinMaxRGBNameD(string path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue)
	{
		return PluginFillThresholdColorsMinMaxRGBNameD(path,frameId,minThreshold,minRed,minGreen,minBlue,maxThreshold,maxRed,maxGreen,maxBlue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsName(string path, int frameId, int threshold, int color)
	{
		PluginFillThresholdColorsName(path,frameId,threshold,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsNameD(string path, double frameId, double threshold, double color)
	{
		return PluginFillThresholdColorsNameD(path,frameId,threshold,color);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue)
	{
		PluginFillThresholdColorsRGB(animationId,frameId,threshold,red,green,blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdColorsRGBName(string path, int frameId, int threshold, int red, int green, int blue)
	{
		PluginFillThresholdColorsRGBName(path,frameId,threshold,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdColorsRGBNameD(string path, double frameId, double threshold, double red, double green, double blue)
	{
		return PluginFillThresholdColorsRGBNameD(path,frameId,threshold,red,green,blue);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		PluginFillThresholdRGBColorsAllFramesRGB(animationId,redThreshold,greenThreshold,blueThreshold,red,green,blue);
	}
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdRGBColorsAllFramesRGBName(string path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		PluginFillThresholdRGBColorsAllFramesRGBName(path,redThreshold,greenThreshold,blueThreshold,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdRGBColorsAllFramesRGBNameD(string path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue)
	{
		return PluginFillThresholdRGBColorsAllFramesRGBNameD(path,redThreshold,greenThreshold,blueThreshold,red,green,blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	public static void FillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		PluginFillThresholdRGBColorsRGB(animationId,frameId,redThreshold,greenThreshold,blueThreshold,red,green,blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	public static void FillThresholdRGBColorsRGBName(string path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
	{
		PluginFillThresholdRGBColorsRGBName(path,frameId,redThreshold,greenThreshold,blueThreshold,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillThresholdRGBColorsRGBNameD(string path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue)
	{
		return PluginFillThresholdRGBColorsRGBNameD(path,frameId,redThreshold,greenThreshold,blueThreshold,red,green,blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
	*/
	public static void FillZeroColor(int animationId, int frameId, int color)
	{
		PluginFillZeroColor(animationId,frameId,color);
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
	*/
	public static void FillZeroColorAllFrames(int animationId, int color)
	{
		PluginFillZeroColorAllFrames(animationId,color);
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
	*/
	public static void FillZeroColorAllFramesName(string path, int color)
	{
		PluginFillZeroColorAllFramesName(path,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorAllFramesNameD(string path, double color)
	{
		return PluginFillZeroColorAllFramesNameD(path,color);
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
	*/
	public static void FillZeroColorAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginFillZeroColorAllFramesRGB(animationId,red,green,blue);
	}
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
	*/
	public static void FillZeroColorAllFramesRGBName(string path, int red, int green, int blue)
	{
		PluginFillZeroColorAllFramesRGBName(path,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		return PluginFillZeroColorAllFramesRGBNameD(path,red,green,blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
	*/
	public static void FillZeroColorName(string path, int frameId, int color)
	{
		PluginFillZeroColorName(path,frameId,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorNameD(string path, double frameId, double color)
	{
		return PluginFillZeroColorNameD(path,frameId,color);
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
	*/
	public static void FillZeroColorRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginFillZeroColorRGB(animationId,frameId,red,green,blue);
	}
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
	*/
	public static void FillZeroColorRGBName(string path, int frameId, int red, int green, int blue)
	{
		PluginFillZeroColorRGBName(path,frameId,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double FillZeroColorRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		return PluginFillZeroColorRGBNameD(path,frameId,red,green,blue);
	}
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by id.
	*/
	public static int Get1DColor(int animationId, int frameId, int led)
	{
		return PluginGet1DColor(animationId,frameId,led);
	}
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by name.
	*/
	public static int Get1DColorName(string path, int frameId, int led)
	{
		return PluginGet1DColorName(path,frameId,led);
	}
	/*
		D suffix for limited data types.
	*/
	public static double Get1DColorNameD(string path, double frameId, double led)
	{
		return PluginGet1DColorNameD(path,frameId,led);
	}
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by id.
	*/
	public static int Get2DColor(int animationId, int frameId, int row, int column)
	{
		return PluginGet2DColor(animationId,frameId,row,column);
	}
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by name.
	*/
	public static int Get2DColorName(string path, int frameId, int row, int column)
	{
		return PluginGet2DColorName(path,frameId,row,column);
	}
	/*
		D suffix for limited data types.
	*/
	public static double Get2DColorNameD(string path, double frameId, double row, double column)
	{
		return PluginGet2DColorNameD(path,frameId,row,column);
	}
	/*
		Get the animation id for the named animation.
	*/
	public static int GetAnimation(string name)
	{
		return PluginGetAnimation(name);
	}
	/*
		`PluginGetAnimationCount` will return the number of loaded animations.
	*/
	public static int GetAnimationCount()
	{
		return PluginGetAnimationCount();
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetAnimationD(string name)
	{
		return PluginGetAnimationD(name);
	}
	/*
		`PluginGetAnimationId` will return the `animationId` given the `index` of 
		the loaded animation. The `index` is zero-based and less than the number 
		returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		get the name of the animation.
	*/
	public static int GetAnimationId(int index)
	{
		return PluginGetAnimationId(index);
	}
	/*
		`PluginGetAnimationName` takes an `animationId` and returns the name of 
		the animation of the `.chroma` animation file. If a name is not available 
		then an empty string will be returned.
	*/
	public static string GetAnimationName(int animationId)
	{
		return PluginGetAnimationName(animationId);
	}
	/*
		Get the current frame of the animation referenced by id.
	*/
	public static int GetCurrentFrame(int animationId)
	{
		return PluginGetCurrentFrame(animationId);
	}
	/*
		Get the current frame of the animation referenced by name.
	*/
	public static int GetCurrentFrameName(string path)
	{
		return PluginGetCurrentFrameName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetCurrentFrameNameD(string path)
	{
		return PluginGetCurrentFrameNameD(path);
	}
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
	*/
	public static int GetDevice(int animationId)
	{
		return PluginGetDevice(animationId);
	}
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
	*/
	public static int GetDeviceName(string path)
	{
		return PluginGetDeviceName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetDeviceNameD(string path)
	{
		return PluginGetDeviceNameD(path);
	}
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetDeviceType(int animationId)
	{
		return PluginGetDeviceType(animationId);
	}
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetDeviceTypeName(string path)
	{
		return PluginGetDeviceTypeName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetDeviceTypeNameD(string path)
	{
		return PluginGetDeviceTypeNameD(path);
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
		return PluginGetFrame(animationId,frameIndex,duration,colors,length);
	}
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
	*/
	public static int GetFrameCount(int animationId)
	{
		return PluginGetFrameCount(animationId);
	}
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
	*/
	public static int GetFrameCountName(string path)
	{
		return PluginGetFrameCountName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetFrameCountNameD(string path)
	{
		return PluginGetFrameCountNameD(path);
	}
	/*
		Get the color of an animation key for the given frame referenced by id.
	*/
	public static int GetKeyColor(int animationId, int frameId, int rzkey)
	{
		return PluginGetKeyColor(animationId,frameId,rzkey);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetKeyColorD(string path, double frameId, double rzkey)
	{
		return PluginGetKeyColorD(path,frameId,rzkey);
	}
	/*
		Get the color of an animation key for the given frame referenced by name.
	*/
	public static int GetKeyColorName(string path, int frameId, int rzkey)
	{
		return PluginGetKeyColorName(path,frameId,rzkey);
	}
	/*
		Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		integer upon success. Returns -1 upon failure.
	*/
	public static int GetMaxColumn(int device)
	{
		return PluginGetMaxColumn(device);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetMaxColumnD(double device)
	{
		return PluginGetMaxColumnD(device);
	}
	/*
		Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetMaxLeds(int device)
	{
		return PluginGetMaxLeds(device);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetMaxLedsD(double device)
	{
		return PluginGetMaxLedsD(device);
	}
	/*
		Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		upon success. Returns -1 upon failure.
	*/
	public static int GetMaxRow(int device)
	{
		return PluginGetMaxRow(device);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetMaxRowD(double device)
	{
		return PluginGetMaxRowD(device);
	}
	/*
		`PluginGetPlayingAnimationCount` will return the number of playing animations.
	*/
	public static int GetPlayingAnimationCount()
	{
		return PluginGetPlayingAnimationCount();
	}
	/*
		`PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		of the playing animation. The `index` is zero-based and less than the number 
		returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		to get the name of the animation.
	*/
	public static int GetPlayingAnimationId(int index)
	{
		return PluginGetPlayingAnimationId(index);
	}
	/*
		Get the RGB color given red, green, and blue.
	*/
	public static int GetRGB(int red, int green, int blue)
	{
		return PluginGetRGB(red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double GetRGBD(double red, double green, double blue)
	{
		return PluginGetRGBD(red,green,blue);
	}
	/*
		Check if the animation has loop enabled referenced by id.
	*/
	public static bool HasAnimationLoop(int animationId)
	{
		return PluginHasAnimationLoop(animationId);
	}
	/*
		Check if the animation has loop enabled referenced by name.
	*/
	public static bool HasAnimationLoopName(string path)
	{
		return PluginHasAnimationLoopName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double HasAnimationLoopNameD(string path)
	{
		return PluginHasAnimationLoopNameD(path);
	}
	/*
		Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		API methods auto initialize the ChromaSDK if not already initialized.
	*/
	public static int Init()
	{
		return PluginInit();
	}
	/*
		D suffix for limited data types.
	*/
	public static double InitD()
	{
		return PluginInitD();
	}
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by id.
	*/
	public static void InsertDelay(int animationId, int frameId, int delay)
	{
		PluginInsertDelay(animationId,frameId,delay);
	}
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by name.
	*/
	public static void InsertDelayName(string path, int frameId, int delay)
	{
		PluginInsertDelayName(path,frameId,delay);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InsertDelayNameD(string path, double frameId, double delay)
	{
		return PluginInsertDelayNameD(path,frameId,delay);
	}
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by id.
	*/
	public static void InsertFrame(int animationId, int sourceFrame, int targetFrame)
	{
		PluginInsertFrame(animationId,sourceFrame,targetFrame);
	}
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by name.
	*/
	public static void InsertFrameName(string path, int sourceFrame, int targetFrame)
	{
		PluginInsertFrameName(path,sourceFrame,targetFrame);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InsertFrameNameD(string path, double sourceFrame, double targetFrame)
	{
		return PluginInsertFrameNameD(path,sourceFrame,targetFrame);
	}
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		id.
	*/
	public static void InvertColors(int animationId, int frameId)
	{
		PluginInvertColors(animationId,frameId);
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
		PluginInvertColorsAllFramesName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InvertColorsAllFramesNameD(string path)
	{
		return PluginInvertColorsAllFramesNameD(path);
	}
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		name.
	*/
	public static void InvertColorsName(string path, int frameId)
	{
		PluginInvertColorsName(path,frameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double InvertColorsNameD(string path, double frameId)
	{
		return PluginInvertColorsNameD(path,frameId);
	}
	/*
		Check if the animation is paused referenced by id.
	*/
	public static bool IsAnimationPaused(int animationId)
	{
		return PluginIsAnimationPaused(animationId);
	}
	/*
		Check if the animation is paused referenced by name.
	*/
	public static bool IsAnimationPausedName(string path)
	{
		return PluginIsAnimationPausedName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsAnimationPausedNameD(string path)
	{
		return PluginIsAnimationPausedNameD(path);
	}
	/*
		The editor dialog is a non-blocking modal window, this method returns true 
		if the modal window is open, otherwise false.
	*/
	public static bool IsDialogOpen()
	{
		return PluginIsDialogOpen();
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsDialogOpenD()
	{
		return PluginIsDialogOpenD();
	}
	/*
		Returns true if the plugin has been initialized. Returns false if the plugin 
		is uninitialized.
	*/
	public static bool IsInitialized()
	{
		return PluginIsInitialized();
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsInitializedD()
	{
		return PluginIsInitializedD();
	}
	/*
		If the method can be invoked the method returns true.
	*/
	public static bool IsPlatformSupported()
	{
		return PluginIsPlatformSupported();
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlatformSupportedD()
	{
		return PluginIsPlatformSupportedD();
	}
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by id.
	*/
	public static bool IsPlaying(int animationId)
	{
		return PluginIsPlaying(animationId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlayingD(double animationId)
	{
		return PluginIsPlayingD(animationId);
	}
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by name.
	*/
	public static bool IsPlayingName(string path)
	{
		return PluginIsPlayingName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlayingNameD(string path)
	{
		return PluginIsPlayingNameD(path);
	}
	/*
		`PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		the method will return true, otherwise false.
	*/
	public static bool IsPlayingType(int deviceType, int device)
	{
		return PluginIsPlayingType(deviceType,device);
	}
	/*
		D suffix for limited data types.
	*/
	public static double IsPlayingTypeD(double deviceType, double device)
	{
		return PluginIsPlayingTypeD(deviceType,device);
	}
	/*
		Do a lerp math operation on a float.
	*/
	public static float Lerp(float start, float end, float amt)
	{
		return PluginLerp(start,end,amt);
	}
	/*
		Lerp from one color to another given t in the range 0.0 to 1.0.
	*/
	public static int LerpColor(int from, int to, float t)
	{
		return PluginLerpColor(from,to,t);
	}
	/*
		Loads `Chroma` effects so that the animation can be played immediately. 
		Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int LoadAnimation(int animationId)
	{
		return PluginLoadAnimation(animationId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double LoadAnimationD(double animationId)
	{
		return PluginLoadAnimationD(animationId);
	}
	/*
		Load the named animation.
	*/
	public static void LoadAnimationName(string path)
	{
		PluginLoadAnimationName(path);
	}
	/*
		Load a composite set of animations.
	*/
	public static void LoadComposite(string name)
	{
		PluginLoadComposite(name);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
	*/
	public static void MakeBlankFrames(int animationId, int frameCount, float duration, int color)
	{
		PluginMakeBlankFrames(animationId,frameCount,duration,color);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
	*/
	public static void MakeBlankFramesName(string path, int frameCount, float duration, int color)
	{
		PluginMakeBlankFramesName(path,frameCount,duration,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesNameD(string path, double frameCount, double duration, double color)
	{
		return PluginMakeBlankFramesNameD(path,frameCount,duration,color);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by id.
	*/
	public static void MakeBlankFramesRandom(int animationId, int frameCount, float duration)
	{
		PluginMakeBlankFramesRandom(animationId,frameCount,duration);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by id.
	*/
	public static void MakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration)
	{
		PluginMakeBlankFramesRandomBlackAndWhite(animationId,frameCount,duration);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by name.
	*/
	public static void MakeBlankFramesRandomBlackAndWhiteName(string path, int frameCount, float duration)
	{
		PluginMakeBlankFramesRandomBlackAndWhiteName(path,frameCount,duration);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesRandomBlackAndWhiteNameD(string path, double frameCount, double duration)
	{
		return PluginMakeBlankFramesRandomBlackAndWhiteNameD(path,frameCount,duration);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by name.
	*/
	public static void MakeBlankFramesRandomName(string path, int frameCount, float duration)
	{
		PluginMakeBlankFramesRandomName(path,frameCount,duration);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesRandomNameD(string path, double frameCount, double duration)
	{
		return PluginMakeBlankFramesRandomNameD(path,frameCount,duration);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
	*/
	public static void MakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue)
	{
		PluginMakeBlankFramesRGB(animationId,frameCount,duration,red,green,blue);
	}
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
	*/
	public static void MakeBlankFramesRGBName(string path, int frameCount, float duration, int red, int green, int blue)
	{
		PluginMakeBlankFramesRGBName(path,frameCount,duration,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MakeBlankFramesRGBNameD(string path, double frameCount, double duration, double red, double green, double blue)
	{
		return PluginMakeBlankFramesRGBNameD(path,frameCount,duration,red,green,blue);
	}
	/*
		Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		the animation id upon success. Returns -1 upon failure.
	*/
	public static int MirrorHorizontally(int animationId)
	{
		return PluginMirrorHorizontally(animationId);
	}
	/*
		Flips the color grid vertically for all `Chroma` animation frames. This 
		method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		animation id upon success. Returns -1 upon failure.
	*/
	public static int MirrorVertically(int animationId)
	{
		return PluginMirrorVertically(animationId);
	}
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in id.
	*/
	public static void MultiplyColorLerpAllFrames(int animationId, int color1, int color2)
	{
		PluginMultiplyColorLerpAllFrames(animationId,color1,color2);
	}
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in name.
	*/
	public static void MultiplyColorLerpAllFramesName(string path, int color1, int color2)
	{
		PluginMultiplyColorLerpAllFramesName(path,color1,color2);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyColorLerpAllFramesNameD(string path, double color1, double color2)
	{
		return PluginMultiplyColorLerpAllFramesNameD(path,color1,color2);
	}
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
	*/
	public static void MultiplyIntensity(int animationId, int frameId, float intensity)
	{
		PluginMultiplyIntensity(animationId,frameId,intensity);
	}
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
	*/
	public static void MultiplyIntensityAllFrames(int animationId, float intensity)
	{
		PluginMultiplyIntensityAllFrames(animationId,intensity);
	}
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
	*/
	public static void MultiplyIntensityAllFramesName(string path, float intensity)
	{
		PluginMultiplyIntensityAllFramesName(path,intensity);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityAllFramesNameD(string path, double intensity)
	{
		return PluginMultiplyIntensityAllFramesNameD(path,intensity);
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue)
	{
		PluginMultiplyIntensityAllFramesRGB(animationId,red,green,blue);
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityAllFramesRGBName(string path, int red, int green, int blue)
	{
		PluginMultiplyIntensityAllFramesRGBName(path,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityAllFramesRGBNameD(string path, double red, double green, double blue)
	{
		return PluginMultiplyIntensityAllFramesRGBNameD(path,red,green,blue);
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityColor(int animationId, int frameId, int color)
	{
		PluginMultiplyIntensityColor(animationId,frameId,color);
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityColorAllFrames(int animationId, int color)
	{
		PluginMultiplyIntensityColorAllFrames(animationId,color);
	}
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityColorAllFramesName(string path, int color)
	{
		PluginMultiplyIntensityColorAllFramesName(path,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityColorAllFramesNameD(string path, double color)
	{
		return PluginMultiplyIntensityColorAllFramesNameD(path,color);
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityColorName(string path, int frameId, int color)
	{
		PluginMultiplyIntensityColorName(path,frameId,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityColorNameD(string path, double frameId, double color)
	{
		return PluginMultiplyIntensityColorNameD(path,frameId,color);
	}
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
	*/
	public static void MultiplyIntensityName(string path, int frameId, float intensity)
	{
		PluginMultiplyIntensityName(path,frameId,intensity);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityNameD(string path, double frameId, double intensity)
	{
		return PluginMultiplyIntensityNameD(path,frameId,intensity);
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
	*/
	public static void MultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue)
	{
		PluginMultiplyIntensityRGB(animationId,frameId,red,green,blue);
	}
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
	*/
	public static void MultiplyIntensityRGBName(string path, int frameId, int red, int green, int blue)
	{
		PluginMultiplyIntensityRGBName(path,frameId,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyIntensityRGBNameD(string path, double frameId, double red, double green, double blue)
	{
		return PluginMultiplyIntensityRGBNameD(path,frameId,red,green,blue);
	}
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
	*/
	public static void MultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2)
	{
		PluginMultiplyNonZeroTargetColorLerp(animationId,frameId,color1,color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2)
	{
		PluginMultiplyNonZeroTargetColorLerpAllFrames(animationId,color1,color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFramesName(string path, int color1, int color2)
	{
		PluginMultiplyNonZeroTargetColorLerpAllFramesName(path,color1,color2);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyNonZeroTargetColorLerpAllFramesNameD(string path, double color1, double color2)
	{
		return PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(path,color1,color2);
	}
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		id.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(animationId,red1,green1,blue1,red2,green2,blue2);
	}
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		name.
	*/
	public static void MultiplyNonZeroTargetColorLerpAllFramesRGBName(string path, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(path,red1,green1,blue1,red2,green2,blue2);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyNonZeroTargetColorLerpAllFramesRGBNameD(string path, double red1, double green1, double blue1, double red2, double green2, double blue2)
	{
		return PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(path,red1,green1,blue1,red2,green2,blue2);
	}
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
	*/
	public static void MultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2)
	{
		PluginMultiplyTargetColorLerp(animationId,frameId,color1,color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
	*/
	public static void MultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2)
	{
		PluginMultiplyTargetColorLerpAllFrames(animationId,color1,color2);
	}
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
	*/
	public static void MultiplyTargetColorLerpAllFramesName(string path, int color1, int color2)
	{
		PluginMultiplyTargetColorLerpAllFramesName(path,color1,color2);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyTargetColorLerpAllFramesNameD(string path, double color1, double color2)
	{
		return PluginMultiplyTargetColorLerpAllFramesNameD(path,color1,color2);
	}
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by id.
	*/
	public static void MultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		PluginMultiplyTargetColorLerpAllFramesRGB(animationId,red1,green1,blue1,red2,green2,blue2);
	}
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by name.
	*/
	public static void MultiplyTargetColorLerpAllFramesRGBName(string path, int red1, int green1, int blue1, int red2, int green2, int blue2)
	{
		PluginMultiplyTargetColorLerpAllFramesRGBName(path,red1,green1,blue1,red2,green2,blue2);
	}
	/*
		D suffix for limited data types.
	*/
	public static double MultiplyTargetColorLerpAllFramesRGBNameD(string path, double red1, double green1, double blue1, double red2, double green2, double blue2)
	{
		return PluginMultiplyTargetColorLerpAllFramesRGBNameD(path,red1,green1,blue1,red2,green2,blue2);
	}
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
	*/
	public static void OffsetColors(int animationId, int frameId, int red, int green, int blue)
	{
		PluginOffsetColors(animationId,frameId,red,green,blue);
	}
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
	*/
	public static void OffsetColorsAllFrames(int animationId, int red, int green, int blue)
	{
		PluginOffsetColorsAllFrames(animationId,red,green,blue);
	}
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
	*/
	public static void OffsetColorsAllFramesName(string path, int red, int green, int blue)
	{
		PluginOffsetColorsAllFramesName(path,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetColorsAllFramesNameD(string path, double red, double green, double blue)
	{
		return PluginOffsetColorsAllFramesNameD(path,red,green,blue);
	}
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
	*/
	public static void OffsetColorsName(string path, int frameId, int red, int green, int blue)
	{
		PluginOffsetColorsName(path,frameId,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetColorsNameD(string path, double frameId, double red, double green, double blue)
	{
		return PluginOffsetColorsNameD(path,frameId,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue)
	{
		PluginOffsetNonZeroColors(animationId,frameId,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue)
	{
		PluginOffsetNonZeroColorsAllFrames(animationId,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColorsAllFramesName(string path, int red, int green, int blue)
	{
		PluginOffsetNonZeroColorsAllFramesName(path,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetNonZeroColorsAllFramesNameD(string path, double red, double green, double blue)
	{
		return PluginOffsetNonZeroColorsAllFramesNameD(path,red,green,blue);
	}
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	public static void OffsetNonZeroColorsName(string path, int frameId, int red, int green, int blue)
	{
		PluginOffsetNonZeroColorsName(path,frameId,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OffsetNonZeroColorsNameD(string path, double frameId, double red, double green, double blue)
	{
		return PluginOffsetNonZeroColorsNameD(path,frameId,red,green,blue);
	}
	/*
		Opens a `Chroma` animation file so that it can be played. Returns an animation 
		id >= 0 upon success. Returns -1 if there was a failure. The animation 
		id is used in most of the API methods.
	*/
	public static int OpenAnimation(string path)
	{
		return PluginOpenAnimation(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OpenAnimationD(string path)
	{
		return PluginOpenAnimationD(path);
	}
	/*
		Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		upon success. Returns -1 if there was a failure.
	*/
	public static int OpenEditorDialog(string path)
	{
		return PluginOpenEditorDialog(path);
	}
	/*
		Open the named animation in the editor dialog and play the animation at 
		start.
	*/
	public static int OpenEditorDialogAndPlay(string path)
	{
		return PluginOpenEditorDialogAndPlay(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OpenEditorDialogAndPlayD(string path)
	{
		return PluginOpenEditorDialogAndPlayD(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OpenEditorDialogD(string path)
	{
		return PluginOpenEditorDialogD(path);
	}
	/*
		Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		parameter. Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int OverrideFrameDuration(int animationId, float duration)
	{
		return PluginOverrideFrameDuration(animationId,duration);
	}
	/*
		D suffix for limited data types.
	*/
	public static double OverrideFrameDurationD(double animationId, double duration)
	{
		return PluginOverrideFrameDurationD(animationId,duration);
	}
	/*
		Override the duration of all frames with the `duration` value. Animation 
		is referenced by name.
	*/
	public static void OverrideFrameDurationName(string path, float duration)
	{
		PluginOverrideFrameDurationName(path,duration);
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
		PluginPauseAnimationName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PauseAnimationNameD(string path)
	{
		return PluginPauseAnimationNameD(path);
	}
	/*
		Plays the `Chroma` animation. This will load the animation, if not loaded 
		previously. Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int PlayAnimation(int animationId)
	{
		return PluginPlayAnimation(animationId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayAnimationD(double animationId)
	{
		return PluginPlayAnimationD(animationId);
	}
	/*
		`PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off` starting at the `frameId`.
	*/
	public static void PlayAnimationFrame(int animationId, int frameId, bool loop)
	{
		PluginPlayAnimationFrame(animationId,frameId,loop);
	}
	/*
		`PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off` starting at the `frameId`.
	*/
	public static void PlayAnimationFrameName(string path, int frameId, bool loop)
	{
		PluginPlayAnimationFrameName(path,frameId,loop);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayAnimationFrameNameD(string path, double frameId, double loop)
	{
		return PluginPlayAnimationFrameNameD(path,frameId,loop);
	}
	/*
		`PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off`.
	*/
	public static void PlayAnimationLoop(int animationId, bool loop)
	{
		PluginPlayAnimationLoop(animationId,loop);
	}
	/*
		`PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off`.
	*/
	public static void PlayAnimationName(string path, bool loop)
	{
		PluginPlayAnimationName(path,loop);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayAnimationNameD(string path, double loop)
	{
		return PluginPlayAnimationNameD(path,loop);
	}
	/*
		`PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will play with looping `on` or `off`.
	*/
	public static void PlayComposite(string name, bool loop)
	{
		PluginPlayComposite(name,loop);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PlayCompositeD(string name, double loop)
	{
		return PluginPlayCompositeD(name,loop);
	}
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Returns the animation id upon success. Returns -1 upon failure.
	*/
	public static int PreviewFrame(int animationId, int frameIndex)
	{
		return PluginPreviewFrame(animationId,frameIndex);
	}
	/*
		D suffix for limited data types.
	*/
	public static double PreviewFrameD(double animationId, double frameIndex)
	{
		return PluginPreviewFrameD(animationId,frameIndex);
	}
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Animaton is referenced by name.
	*/
	public static void PreviewFrameName(string path, int frameIndex)
	{
		PluginPreviewFrameName(path,frameIndex);
	}
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by id.
	*/
	public static void ReduceFrames(int animationId, int n)
	{
		PluginReduceFrames(animationId,n);
	}
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by name.
	*/
	public static void ReduceFramesName(string path, int n)
	{
		PluginReduceFramesName(path,n);
	}
	/*
		D suffix for limited data types.
	*/
	public static double ReduceFramesNameD(string path, double n)
	{
		return PluginReduceFramesNameD(path,n);
	}
	/*
		Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		upon success. Returns -1 upon failure.
	*/
	public static int ResetAnimation(int animationId)
	{
		return PluginResetAnimation(animationId);
	}
	/*
		Resume the animation with loop `ON` or `OFF` referenced by id.
	*/
	public static void ResumeAnimation(int animationId, bool loop)
	{
		PluginResumeAnimation(animationId,loop);
	}
	/*
		Resume the animation with loop `ON` or `OFF` referenced by name.
	*/
	public static void ResumeAnimationName(string path, bool loop)
	{
		PluginResumeAnimationName(path,loop);
	}
	/*
		D suffix for limited data types.
	*/
	public static double ResumeAnimationNameD(string path, double loop)
	{
		return PluginResumeAnimationNameD(path,loop);
	}
	/*
		Reverse the animation frame order of the `Chroma` animation. Returns the 
		animation id upon success. Returns -1 upon failure. Animation is referenced 
		by id.
	*/
	public static int Reverse(int animationId)
	{
		return PluginReverse(animationId);
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
		PluginReverseAllFramesName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double ReverseAllFramesNameD(string path)
	{
		return PluginReverseAllFramesNameD(path);
	}
	/*
		Save the animation referenced by id to the path specified.
	*/
	public static int SaveAnimation(int animationId, string path)
	{
		return PluginSaveAnimation(animationId,path);
	}
	/*
		Save the named animation to the target path specified.
	*/
	public static int SaveAnimationName(string sourceAnimation, string targetAnimation)
	{
		return PluginSaveAnimationName(sourceAnimation,targetAnimation);
	}
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by id.
	*/
	public static void Set1DColor(int animationId, int frameId, int led, int color)
	{
		PluginSet1DColor(animationId,frameId,led,color);
	}
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by name.
	*/
	public static void Set1DColorName(string path, int frameId, int led, int color)
	{
		PluginSet1DColorName(path,frameId,led,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double Set1DColorNameD(string path, double frameId, double led, double color)
	{
		return PluginSet1DColorNameD(path,frameId,led,color);
	}
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by id.
	*/
	public static void Set2DColor(int animationId, int frameId, int row, int column, int color)
	{
		PluginSet2DColor(animationId,frameId,row,column,color);
	}
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by name.
	*/
	public static void Set2DColorName(string path, int frameId, int row, int column, int color)
	{
		PluginSet2DColorName(path,frameId,row,column,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double Set2DColorNameD(string path, double frameId, double rowColumnIndex, double color)
	{
		return PluginSet2DColorNameD(path,frameId,rowColumnIndex,color);
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
		PluginSetChromaCustomColorAllFramesName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetChromaCustomColorAllFramesNameD(string path)
	{
		return PluginSetChromaCustomColorAllFramesNameD(path);
	}
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by id.
	*/
	public static void SetChromaCustomFlag(int animationId, bool flag)
	{
		PluginSetChromaCustomFlag(animationId,flag);
	}
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by name.
	*/
	public static void SetChromaCustomFlagName(string path, bool flag)
	{
		PluginSetChromaCustomFlagName(path,flag);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetChromaCustomFlagNameD(string path, double flag)
	{
		return PluginSetChromaCustomFlagNameD(path,flag);
	}
	/*
		Set the current frame of the animation referenced by id.
	*/
	public static void SetCurrentFrame(int animationId, int frameId)
	{
		PluginSetCurrentFrame(animationId,frameId);
	}
	/*
		Set the current frame of the animation referenced by name.
	*/
	public static void SetCurrentFrameName(string path, int frameId)
	{
		PluginSetCurrentFrameName(path,frameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetCurrentFrameNameD(string path, double frameId)
	{
		return PluginSetCurrentFrameNameD(path,frameId);
	}
	/*
		Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		the animation id upon success. Returns -1 upon failure.
	*/
	public static int SetDevice(int animationId, int deviceType, int device)
	{
		return PluginSetDevice(animationId,deviceType,device);
	}
	/*
		SetEffect will display the referenced effect id.
	*/
	public static int SetEffect(System.Guid effectId)
	{
		return PluginSetEffect(effectId);
	}
	/*
		Set animation key to a static color for the given frame.
	*/
	public static void SetKeyColor(int animationId, int frameId, int rzkey, int color)
	{
		PluginSetKeyColor(animationId,frameId,rzkey,color);
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
	*/
	public static void SetKeyColorAllFrames(int animationId, int rzkey, int color)
	{
		PluginSetKeyColorAllFrames(animationId,rzkey,color);
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
	*/
	public static void SetKeyColorAllFramesName(string path, int rzkey, int color)
	{
		PluginSetKeyColorAllFramesName(path,rzkey,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorAllFramesNameD(string path, double rzkey, double color)
	{
		return PluginSetKeyColorAllFramesNameD(path,rzkey,color);
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
	*/
	public static void SetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyColorAllFramesRGB(animationId,rzkey,red,green,blue);
	}
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
	*/
	public static void SetKeyColorAllFramesRGBName(string path, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyColorAllFramesRGBName(path,rzkey,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorAllFramesRGBNameD(string path, double rzkey, double red, double green, double blue)
	{
		return PluginSetKeyColorAllFramesRGBNameD(path,rzkey,red,green,blue);
	}
	/*
		Set animation key to a static color for the given frame.
	*/
	public static void SetKeyColorName(string path, int frameId, int rzkey, int color)
	{
		PluginSetKeyColorName(path,frameId,rzkey,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorNameD(string path, double frameId, double rzkey, double color)
	{
		return PluginSetKeyColorNameD(path,frameId,rzkey,color);
	}
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by id.
	*/
	public static void SetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyColorRGB(animationId,frameId,rzkey,red,green,blue);
	}
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by name.
	*/
	public static void SetKeyColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyColorRGBName(path,frameId,rzkey,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
	{
		return PluginSetKeyColorRGBNameD(path,frameId,rzkey,red,green,blue);
	}
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
	*/
	public static void SetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color)
	{
		PluginSetKeyNonZeroColor(animationId,frameId,rzkey,color);
	}
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
	*/
	public static void SetKeyNonZeroColorName(string path, int frameId, int rzkey, int color)
	{
		PluginSetKeyNonZeroColorName(path,frameId,rzkey,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyNonZeroColorNameD(string path, double frameId, double rzkey, double color)
	{
		return PluginSetKeyNonZeroColorNameD(path,frameId,rzkey,color);
	}
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by id.
	*/
	public static void SetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyNonZeroColorRGB(animationId,frameId,rzkey,red,green,blue);
	}
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by name.
	*/
	public static void SetKeyNonZeroColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyNonZeroColorRGBName(path,frameId,rzkey,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyNonZeroColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
	{
		return PluginSetKeyNonZeroColorRGBNameD(path,frameId,rzkey,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
	*/
	public static void SetKeysColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysColor(animationId,frameId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
	*/
	public static void SetKeysColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysColorAllFrames(animationId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
	*/
	public static void SetKeysColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysColorAllFramesName(path,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
	*/
	public static void SetKeysColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysColorAllFramesRGB(animationId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
	*/
	public static void SetKeysColorAllFramesRGBName(string path, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysColorAllFramesRGBName(path,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame.
	*/
	public static void SetKeysColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysColorName(path,frameId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
	*/
	public static void SetKeysColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysColorRGB(animationId,frameId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by name.
	*/
	public static void SetKeysColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysColorRGBName(path,frameId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black.
	*/
	public static void SetKeysNonZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysNonZeroColor(animationId,frameId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
	*/
	public static void SetKeysNonZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysNonZeroColorAllFrames(animationId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for all frames if the existing 
		color is not already black. Reference animation by name.
	*/
	public static void SetKeysNonZeroColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysNonZeroColorAllFramesName(path,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black. Reference animation by name.
	*/
	public static void SetKeysNonZeroColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysNonZeroColorName(path,frameId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
	*/
	public static void SetKeysNonZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysNonZeroColorRGB(animationId,frameId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by name.
	*/
	public static void SetKeysNonZeroColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysNonZeroColorRGBName(path,frameId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysZeroColor(animationId,frameId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysZeroColorAllFrames(animationId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysZeroColorAllFramesName(path,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysZeroColorAllFramesRGB(animationId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorAllFramesRGBName(string path, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysZeroColorAllFramesRGBName(path,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
	{
		PluginSetKeysZeroColorName(path,frameId,rzkeys,keyCount,color);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
	*/
	public static void SetKeysZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysZeroColorRGB(animationId,frameId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
	*/
	public static void SetKeysZeroColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
	{
		PluginSetKeysZeroColorRGBName(path,frameId,rzkeys,keyCount,red,green,blue);
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
	*/
	public static void SetKeyZeroColor(int animationId, int frameId, int rzkey, int color)
	{
		PluginSetKeyZeroColor(animationId,frameId,rzkey,color);
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
	*/
	public static void SetKeyZeroColorName(string path, int frameId, int rzkey, int color)
	{
		PluginSetKeyZeroColorName(path,frameId,rzkey,color);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyZeroColorNameD(string path, double frameId, double rzkey, double color)
	{
		return PluginSetKeyZeroColorNameD(path,frameId,rzkey,color);
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
	*/
	public static void SetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyZeroColorRGB(animationId,frameId,rzkey,red,green,blue);
	}
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
	*/
	public static void SetKeyZeroColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
	{
		PluginSetKeyZeroColorRGBName(path,frameId,rzkey,red,green,blue);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SetKeyZeroColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
	{
		return PluginSetKeyZeroColorRGBNameD(path,frameId,rzkey,red,green,blue);
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
		return PluginStopAnimation(animationId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopAnimationD(double animationId)
	{
		return PluginStopAnimationD(animationId);
	}
	/*
		`PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will stop if playing.
	*/
	public static void StopAnimationName(string path)
	{
		PluginStopAnimationName(path);
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopAnimationNameD(string path)
	{
		return PluginStopAnimationNameD(path);
	}
	/*
		`PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		it will be stopped.
	*/
	public static void StopAnimationType(int deviceType, int device)
	{
		PluginStopAnimationType(deviceType,device);
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopAnimationTypeD(double deviceType, double device)
	{
		return PluginStopAnimationTypeD(deviceType,device);
	}
	/*
		`PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will be stopped if playing.
	*/
	public static void StopComposite(string name)
	{
		PluginStopComposite(name);
	}
	/*
		D suffix for limited data types.
	*/
	public static double StopCompositeD(string name)
	{
		return PluginStopCompositeD(name);
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by id.
	*/
	public static void SubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginSubtractNonZeroAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by name.
	*/
	public static void SubtractNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginSubtractNonZeroAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginSubtractNonZeroAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by id.
	*/
	public static void SubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginSubtractNonZeroAllKeysAllFramesOffset(sourceAnimationId,targetAnimationId,offset);
	}
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by name.
	*/
	public static void SubtractNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		PluginSubtractNonZeroAllKeysAllFramesOffsetName(sourceAnimation,targetAnimation,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		return PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation,targetAnimation,offset);
	}
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by id.
	*/
	public static void SubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginSubtractNonZeroAllKeysOffset(sourceAnimationId,targetAnimationId,frameId,offset);
	}
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by name.
	*/
	public static void SubtractNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		PluginSubtractNonZeroAllKeysOffsetName(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		return PluginSubtractNonZeroAllKeysOffsetNameD(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by id.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
	{
		PluginSubtractNonZeroTargetAllKeysAllFrames(sourceAnimationId,targetAnimationId);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by name.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
	{
		PluginSubtractNonZeroTargetAllKeysAllFramesName(sourceAnimation,targetAnimation);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
	{
		return PluginSubtractNonZeroTargetAllKeysAllFramesNameD(sourceAnimation,targetAnimation);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by id.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
	{
		PluginSubtractNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId,targetAnimationId,offset);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by name.
	*/
	public static void SubtractNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
	{
		PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation,targetAnimation,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
	{
		return PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation,targetAnimation,offset);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by id.
	*/
	public static void SubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
	{
		PluginSubtractNonZeroTargetAllKeysOffset(sourceAnimationId,targetAnimationId,frameId,offset);
	}
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by name.
	*/
	public static void SubtractNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
	{
		PluginSubtractNonZeroTargetAllKeysOffsetName(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		D suffix for limited data types.
	*/
	public static double SubtractNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
	{
		return PluginSubtractNonZeroTargetAllKeysOffsetNameD(sourceAnimation,targetAnimation,frameId,offset);
	}
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by id.
	*/
	public static void TrimEndFrames(int animationId, int lastFrameId)
	{
		PluginTrimEndFrames(animationId,lastFrameId);
	}
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by name.
	*/
	public static void TrimEndFramesName(string path, int lastFrameId)
	{
		PluginTrimEndFramesName(path,lastFrameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double TrimEndFramesNameD(string path, double lastFrameId)
	{
		return PluginTrimEndFramesNameD(path,lastFrameId);
	}
	/*
		Remove the frame from the animation. Reference animation by id.
	*/
	public static void TrimFrame(int animationId, int frameId)
	{
		PluginTrimFrame(animationId,frameId);
	}
	/*
		Remove the frame from the animation. Reference animation by name.
	*/
	public static void TrimFrameName(string path, int frameId)
	{
		PluginTrimFrameName(path,frameId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double TrimFrameNameD(string path, double frameId)
	{
		return PluginTrimFrameNameD(path,frameId);
	}
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by id.
	*/
	public static void TrimStartFrames(int animationId, int numberOfFrames)
	{
		PluginTrimStartFrames(animationId,numberOfFrames);
	}
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by name.
	*/
	public static void TrimStartFramesName(string path, int numberOfFrames)
	{
		PluginTrimStartFramesName(path,numberOfFrames);
	}
	/*
		D suffix for limited data types.
	*/
	public static double TrimStartFramesNameD(string path, double numberOfFrames)
	{
		return PluginTrimStartFramesNameD(path,numberOfFrames);
	}
	/*
		Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns -1 upon failure.
	*/
	public static int Uninit()
	{
		return PluginUninit();
	}
	/*
		D suffix for limited data types.
	*/
	public static double UninitD()
	{
		return PluginUninitD();
	}
	/*
		Unloads `Chroma` effects to free up resources. Returns the animation id 
		upon success. Returns -1 upon failure. Reference the animation by id.
	*/
	public static int UnloadAnimation(int animationId)
	{
		return PluginUnloadAnimation(animationId);
	}
	/*
		D suffix for limited data types.
	*/
	public static double UnloadAnimationD(double animationId)
	{
		return PluginUnloadAnimationD(animationId);
	}
	/*
		Unload the animation effects. Reference the animation by name.
	*/
	public static void UnloadAnimationName(string path)
	{
		PluginUnloadAnimationName(path);
	}
	/*
		Unload the the composite set of animation effects. Reference the animation 
		by name.
	*/
	public static void UnloadComposite(string name)
	{
		PluginUnloadComposite(name);
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
		return PluginUpdateFrame(animationId,frameIndex,duration,colors,length);
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
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginAddFrame(int animationId, float duration, int[] colors, int length);
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Add source color to target where color is not black for all frames, reference 
		source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Add source color to target where color is not black for all frames starting 
		at offset for the length of the source, reference source and target by 
		name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Add source color to target where color is not black for the source frame 
		and target offset frame, reference source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Add source color to target where the target color is not black for all frames, 
		reference source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Add source color to target where the target color is not black for all frames 
		starting at offset for the length of the source, reference source and target 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Add source color to target where target color is not blank from the source 
		frame to the target offset frame, reference source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAddNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAddNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Append all source frames to the target animation, reference source and target 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAppendAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Append all source frames to the target animation, reference source and target 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginAppendAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginAppendAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		`PluginClearAll` will issue a `CLEAR` effect for all devices.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginClearAll();
	/*
		`PluginClearAnimationType` will issue a `CLEAR` effect for the given device.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginClearAnimationType(int deviceType, int device);
	/*
		`PluginCloseAll` closes all open animations so they can be reloaded from 
		disk. The set of animations will be stopped if playing.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCloseAll();
	/*
		Closes the `Chroma` animation to free up resources referenced by id. Returns 
		the animation id upon success. Returns -1 upon failure. This might be used 
		while authoring effects if there was a change necessitating re-opening 
		the animation. The animation id can no longer be used once closed.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCloseAnimation(int animationId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCloseAnimationD(double animationId);
	/*
		Closes the `Chroma` animation referenced by name so that the animation can 
		be reloaded from disk.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCloseAnimationName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCloseAnimationNameD(IntPtr path);
	/*
		`PluginCloseComposite` closes a set of animations so they can be reloaded 
		from disk. The set of animations will be stopped if playing.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCloseComposite(IntPtr name);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCloseCompositeD(IntPtr name);
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCopyAnimation(int sourceAnimationId, IntPtr targetAnimation);
	/*
		Copy animation to named target animation in memory. If target animation 
		exists, close first. Source is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyAnimationName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyAnimationNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity);
	/*
		Copy blue channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyBlueChannelAllFramesName(IntPtr path, float redIntensity, float greenIntensity);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyBlueChannelAllFramesNameD(IntPtr path, double redIntensity, double greenIntensity);
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity);
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyGreenChannelAllFramesName(IntPtr path, float redIntensity, float blueIntensity);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyGreenChannelAllFramesNameD(IntPtr path, double redIntensity, double blueIntensity);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame. Reference the source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames. Reference the source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation, int rzkey);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyKeyColorAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset);
	/*
		Copy animation key color from the source animation to the target animation 
		for all frames, starting at the offset for the length of the source animation. 
		Source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int rzkey, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyKeyColorAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double rzkey, double offset);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
	/*
		Copy source animation to target animation for the given frame. Source and 
		target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames. Reference source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Copy nonzero colors from a source animation to a target animation for all 
		frames starting at the offset for the length of the source animation. The 
		source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Copy nonzero colors from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId);
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Copy nonzero colors from the source animation to the target animation from 
		the source frame to the target offset frame. Source and target are referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	/*
		Copy animation key color from the source animation to the target animation 
		for the given frame where color is not zero.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. Source and target 
		are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames. Source and target are referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for all frames starting at the target offset 
		for the length of the source animation. Source and target animations are 
		referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified frame. The source and target 
		are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Copy nonzero colors from the source animation to the target animation where 
		the target color is nonzero for the specified source frame and target offset 
		frame. The source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Copy red channel to other channels for all frames. Intensity range is 0.0 
		to 1.0. Reference the animation by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity);
	/*
		Copy green channel to other channels for all frames. Intensity range is 
		0.0 to 1.0. Reference the animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyRedChannelAllFramesName(IntPtr path, float greenIntensity, float blueIntensity);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyRedChannelAllFramesNameD(IntPtr path, double greenIntensity, double blueIntensity);
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy zero colors from source animation to target animation for all frames. 
		Source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Copy zero colors from source animation to target animation for all frames 
		starting at the target offset for the length of the source animation. Source 
		and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
	/*
		Copy zero key color from source animation to target animation for the specified 
		frame. Source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Copy nonzero color from source animation to target animation where target 
		is zero for all frames. Source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginCopyZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginCopyZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateChromaLinkEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateEffect(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateHeadsetEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateKeyboardEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateKeypadEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateMouseEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreCreateMousepadEffect(int Effect, PRZPARAM pParam, RZEFFECTID pEffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreDeleteEffect(RZEFFECTID EffectId);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreInit();
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreQueryDevice(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE DeviceInfo);
	/*
		Direct access to low level API.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCoreSetEffect(RZEFFECTID EffectId);
	/*
		Direct access to low level API.
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
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCreateAnimationInMemory(int deviceType, int device);
	/*
		Create a device specific effect.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginCreateEffect(RZDEVICEID deviceId, ChromaSDK::EFFECT_TYPE effect, int[] colors, int size, ChromaSDK::FChromaSDKGuid* effectId);
	/*
		Delete an effect given the effect id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginDeleteEffect(System.Guid effectId);
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFirstFrame(int animationId, int frameCount);
	/*
		Duplicate the first animation frame so that the animation length matches 
		the frame count. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFirstFrameName(IntPtr path, int frameCount);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginDuplicateFirstFrameNameD(IntPtr path, double frameCount);
	/*
		Duplicate all the frames of the animation to double the animation length. 
		Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		The animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFrames(int animationId);
	/*
		Duplicate all the frames of the animation to double the animation length. 
		Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		The animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateFramesName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginDuplicateFramesNameD(IntPtr path);
	/*
		Duplicate all the animation frames in reverse so that the animation plays 
		forwards and backwards. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateMirrorFrames(int animationId);
	/*
		Duplicate all the animation frames in reverse so that the animation plays 
		forwards and backwards. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginDuplicateMirrorFramesName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginDuplicateMirrorFramesNameD(IntPtr path);
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeEndFrames(int animationId, int fade);
	/*
		Fade the animation to black starting at the fade frame index to the end 
		of the animation. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeEndFramesName(IntPtr path, int fade);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFadeEndFramesNameD(IntPtr path, double fade);
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeStartFrames(int animationId, int fade);
	/*
		Fade the animation from black to full color starting at 0 to the fade frame 
		index. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFadeStartFramesName(IntPtr path, int fade);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFadeStartFramesNameD(IntPtr path, double fade);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColor(int animationId, int frameId, int color);
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFrames(int animationId, int color);
	/*
		Set the RGB value for all colors for all frames. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorAllFramesNameD(IntPtr path, double color);
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		for red, green, and blue parameters. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorNameD(IntPtr path, double frameId, double color);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		Set the RGB value for all colors in the specified frame. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColor(int animationId, int frameId, int color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFrames(int animationId, int color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorAllFramesNameD(IntPtr path, double color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors for all frames. 
		Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorNameD(IntPtr path, double frameId, double color);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Set the RGB value for a subset of colors in the specified 
		frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillNonZeroColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillNonZeroColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColors(int animationId, int frameId);
	/*
		Fill the frame with random RGB values for all frames. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsAllFrames(int animationId);
	/*
		Fill the frame with random RGB values for all frames. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsAllFramesNameD(IntPtr path);
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhite(int animationId, int frameId);
	/*
		Fill the frame with random black and white values for all frames. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhiteAllFrames(int animationId);
	/*
		Fill the frame with random black and white values for all frames. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhiteAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsBlackAndWhiteAllFramesNameD(IntPtr path);
	/*
		Fill the frame with random black and white values for the specified frame. 
		Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsBlackAndWhiteName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsBlackAndWhiteNameD(IntPtr path, double frameId);
	/*
		Fill the frame with random RGB values for the given frame. Animation is 
		referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillRandomColorsName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillRandomColorsNameD(IntPtr path, double frameId);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColors(int animationId, int frameId, int threshold, int color);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFrames(int animationId, int threshold, int color);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFramesName(IntPtr path, int threshold, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsAllFramesNameD(IntPtr path, double threshold, double color);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsAllFramesRGBName(IntPtr path, int threshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsAllFramesRGBNameD(IntPtr path, double threshold, double red, double green, double blue);
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		Fill all frames with the min RGB color where the animation color is less 
		than the min threshold AND with the max RGB color where the animation is 
		more than the max threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxAllFramesRGBName(IntPtr path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsMinMaxAllFramesRGBNameD(IntPtr path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		Fill the specified frame with the min RGB color where the animation color 
		is less than the min threshold AND with the max RGB color where the animation 
		is more than the max threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsMinMaxRGBName(IntPtr path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsMinMaxRGBNameD(IntPtr path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsName(IntPtr path, int frameId, int threshold, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsNameD(IntPtr path, double frameId, double threshold, double color);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdColorsRGBName(IntPtr path, int frameId, int threshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdColorsRGBNameD(IntPtr path, double frameId, double threshold, double red, double green, double blue);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		Fill all frames with RGB color where the animation color is less than the 
		RGB threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsAllFramesRGBName(IntPtr path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdRGBColorsAllFramesRGBNameD(IntPtr path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		Fill the specified frame with RGB color where the animation color is less 
		than the RGB threshold. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillThresholdRGBColorsRGBName(IntPtr path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillThresholdRGBColorsRGBNameD(IntPtr path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColor(int animationId, int frameId, int color);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFrames(int animationId, int color);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorAllFramesNameD(IntPtr path, double color);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		Fill all frames with RGB color where the animation color is zero. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorNameD(IntPtr path, double frameId, double color);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		Fill the specified frame with RGB color where the animation color is zero. 
		Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginFillZeroColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginFillZeroColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet1DColor(int animationId, int frameId, int led);
	/*
		Get the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet1DColorName(IntPtr path, int frameId, int led);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGet1DColorNameD(IntPtr path, double frameId, double led);
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet2DColor(int animationId, int frameId, int row, int column);
	/*
		Get the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGet2DColorName(IntPtr path, int frameId, int row, int column);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGet2DColorNameD(IntPtr path, double frameId, double row, double column);
	/*
		Get the animation id for the named animation.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetAnimation(IntPtr name);
	/*
		`PluginGetAnimationCount` will return the number of loaded animations.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetAnimationCount();
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetAnimationD(IntPtr name);
	/*
		`PluginGetAnimationId` will return the `animationId` given the `index` of 
		the loaded animation. The `index` is zero-based and less than the number 
		returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		get the name of the animation.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetAnimationId(int index);
	/*
		`PluginGetAnimationName` takes an `animationId` and returns the name of 
		the animation of the `.chroma` animation file. If a name is not available 
		then an empty string will be returned.
	*/
	[DllImport(DLL_NAME)]
	private static extern IntPtr PluginGetAnimationName(int animationId);
	/*
		Get the current frame of the animation referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetCurrentFrame(int animationId);
	/*
		Get the current frame of the animation referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetCurrentFrameName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetCurrentFrameNameD(IntPtr path);
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDevice(int animationId);
	/*
		Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		animation respective to the `deviceType`, as an integer upon success. Returns 
		-1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDeviceName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetDeviceNameD(IntPtr path);
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDeviceType(int animationId);
	/*
		Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetDeviceTypeName(IntPtr path);
	/*
		D suffix for limited data types.
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
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetFrame(int animationId, int frameIndex, float* duration, int[] colors, int length);
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetFrameCount(int animationId);
	/*
		Returns the frame count of a `Chroma` animation upon success. Returns -1 
		upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetFrameCountName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetFrameCountNameD(IntPtr path);
	/*
		Get the color of an animation key for the given frame referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetKeyColor(int animationId, int frameId, int rzkey);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetKeyColorD(IntPtr path, double frameId, double rzkey);
	/*
		Get the color of an animation key for the given frame referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetKeyColorName(IntPtr path, int frameId, int rzkey);
	/*
		Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		integer upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetMaxColumn(int device);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetMaxColumnD(double device);
	/*
		Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetMaxLeds(int device);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetMaxLedsD(double device);
	/*
		Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetMaxRow(int device);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetMaxRowD(double device);
	/*
		`PluginGetPlayingAnimationCount` will return the number of playing animations.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetPlayingAnimationCount();
	/*
		`PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		of the playing animation. The `index` is zero-based and less than the number 
		returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		to get the name of the animation.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetPlayingAnimationId(int index);
	/*
		Get the RGB color given red, green, and blue.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginGetRGB(int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginGetRGBD(double red, double green, double blue);
	/*
		Check if the animation has loop enabled referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginHasAnimationLoop(int animationId);
	/*
		Check if the animation has loop enabled referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginHasAnimationLoopName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginHasAnimationLoopNameD(IntPtr path);
	/*
		Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		API methods auto initialize the ChromaSDK if not already initialized.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginInit();
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInitD();
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertDelay(int animationId, int frameId, int delay);
	/*
		Insert an animation delay by duplicating the frame by the delay number of 
		times. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertDelayName(IntPtr path, int frameId, int delay);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInsertDelayNameD(IntPtr path, double frameId, double delay);
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertFrame(int animationId, int sourceFrame, int targetFrame);
	/*
		Duplicate the source frame index at the target frame index. Animation is 
		referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInsertFrameName(IntPtr path, int sourceFrame, int targetFrame);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInsertFrameNameD(IntPtr path, double sourceFrame, double targetFrame);
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColors(int animationId, int frameId);
	/*
		Invert all the colors for all frames. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColorsAllFrames(int animationId);
	/*
		Invert all the colors for all frames. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColorsAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInvertColorsAllFramesNameD(IntPtr path);
	/*
		Invert all the colors at the specified frame. Animation is referenced by 
		name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginInvertColorsName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginInvertColorsNameD(IntPtr path, double frameId);
	/*
		Check if the animation is paused referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsAnimationPaused(int animationId);
	/*
		Check if the animation is paused referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsAnimationPausedName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsAnimationPausedNameD(IntPtr path);
	/*
		The editor dialog is a non-blocking modal window, this method returns true 
		if the modal window is open, otherwise false.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsDialogOpen();
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsDialogOpenD();
	/*
		Returns true if the plugin has been initialized. Returns false if the plugin 
		is uninitialized.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsInitialized();
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsInitializedD();
	/*
		If the method can be invoked the method returns true.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlatformSupported();
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlatformSupportedD();
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlaying(int animationId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlayingD(double animationId);
	/*
		`PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The method 
		will return whether the animation is playing or not. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlayingName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlayingNameD(IntPtr path);
	/*
		`PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		the method will return true, otherwise false.
	*/
	[DllImport(DLL_NAME)]
	private static extern bool PluginIsPlayingType(int deviceType, int device);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginIsPlayingTypeD(double deviceType, double device);
	/*
		Do a lerp math operation on a float.
	*/
	[DllImport(DLL_NAME)]
	private static extern float PluginLerp(float start, float end, float amt);
	/*
		Lerp from one color to another given t in the range 0.0 to 1.0.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginLerpColor(int from, int to, float t);
	/*
		Loads `Chroma` effects so that the animation can be played immediately. 
		Returns the animation id upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginLoadAnimation(int animationId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginLoadAnimationD(double animationId);
	/*
		Load the named animation.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginLoadAnimationName(IntPtr path);
	/*
		Load a composite set of animations.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginLoadComposite(IntPtr name);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFrames(int animationId, int frameCount, float duration, int color);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesName(IntPtr path, int frameCount, float duration, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesNameD(IntPtr path, double frameCount, double duration, double color);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandom(int animationId, int frameCount, float duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random black and white. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandomBlackAndWhiteName(IntPtr path, int frameCount, float duration);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesRandomBlackAndWhiteNameD(IntPtr path, double frameCount, double duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color is random. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRandomName(IntPtr path, int frameCount, float duration);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesRandomNameD(IntPtr path, double frameCount, double duration);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue);
	/*
		Make a blank animation for the length of the frame count. Frame duration 
		defaults to the duration. The frame color defaults to color. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMakeBlankFramesRGBName(IntPtr path, int frameCount, float duration, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMakeBlankFramesRGBNameD(IntPtr path, double frameCount, double duration, double red, double green, double blue);
	/*
		Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		the animation id upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginMirrorHorizontally(int animationId);
	/*
		Flips the color grid vertically for all `Chroma` animation frames. This 
		method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		animation id upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginMirrorVertically(int animationId);
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyColorLerpAllFrames(int animationId, int color1, int color2);
	/*
		Multiply the color intensity with the lerp result from color 1 to color 
		2 using the frame index divided by the frame count for the `t` parameter. 
		Animation is referenced in name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyColorLerpAllFramesName(IntPtr path, int color1, int color2);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensity(int animationId, int frameId, float intensity);
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFrames(int animationId, float intensity);
	/*
		Multiply all the colors for all frames by the intensity value. The valid 
		the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		equally. An intensity of 0.5 would half the color value. Black colors in 
		the frame will not be affected by this method.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFramesName(IntPtr path, float intensity);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityAllFramesNameD(IntPtr path, double intensity);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityAllFramesRGBName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColor(int animationId, int frameId, int color);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColorAllFrames(int animationId, int color);
	/*
		Multiply all frames by the RBG color intensity. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColorAllFramesName(IntPtr path, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityColorAllFramesNameD(IntPtr path, double color);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityColorName(IntPtr path, int frameId, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityColorNameD(IntPtr path, double frameId, double color);
	/*
		Multiply all the colors in the frame by the intensity value. The valid the 
		intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		An intensity of 0.5 would half the color value. Black colors in the frame 
		will not be affected by this method.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityName(IntPtr path, int frameId, float intensity);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityNameD(IntPtr path, double frameId, double intensity);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue);
	/*
		Multiply the specific frame by the RBG color intensity. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyIntensityRGBName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyIntensityRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesName(IntPtr path, int color1, int color2);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		Multiply the specific frame by the color lerp result between RGB 1 and 2 
		using the frame color value as the `t` value. Animation is referenced by 
		name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(IntPtr path, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(IntPtr path, double red1, double green1, double blue1, double red2, double green2, double blue2);
	/*
		Multiply the specific frame by the color lerp result between color 1 and 
		2 using the frame color value as the `t` value. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2);
	/*
		Multiply all frames by the color lerp result between color 1 and 2 using 
		the frame color value as the `t` value. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFramesName(IntPtr path, int color1, int color2);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyTargetColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		frame color value as the `t` value. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginMultiplyTargetColorLerpAllFramesRGBName(IntPtr path, int red1, int green1, int blue1, int red2, int green2, int blue2);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginMultiplyTargetColorLerpAllFramesRGBNameD(IntPtr path, double red1, double green1, double blue1, double red2, double green2, double blue2);
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColors(int animationId, int frameId, int red, int green, int blue);
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColorsAllFrames(int animationId, int red, int green, int blue);
	/*
		Offset all colors for all frames using the RGB offset. Use the range of 
		-255 to 255 for red, green, and blue parameters. Negative values remove 
		color. Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColorsAllFramesName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetColorsAllFramesNameD(IntPtr path, double red, double green, double blue);
	/*
		Offset all colors in the frame using the RGB offset. Use the range of -255 
		to 255 for red, green, and blue parameters. Negative values remove color. 
		Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetColorsName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetColorsNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors for all frames using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColorsAllFramesName(IntPtr path, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetNonZeroColorsAllFramesNameD(IntPtr path, double red, double green, double blue);
	/*
		This method will only update colors in the animation that are not already 
		set to black. Offset a subset of colors in the frame using the RGB offset. 
		Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		values remove color. Positive values add color.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOffsetNonZeroColorsName(IntPtr path, int frameId, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOffsetNonZeroColorsNameD(IntPtr path, double frameId, double red, double green, double blue);
	/*
		Opens a `Chroma` animation file so that it can be played. Returns an animation 
		id >= 0 upon success. Returns -1 if there was a failure. The animation 
		id is used in most of the API methods.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOpenAnimation(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOpenAnimationD(IntPtr path);
	/*
		Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		upon success. Returns -1 if there was a failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOpenEditorDialog(IntPtr path);
	/*
		Open the named animation in the editor dialog and play the animation at 
		start.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOpenEditorDialogAndPlay(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOpenEditorDialogAndPlayD(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOpenEditorDialogD(IntPtr path);
	/*
		Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		parameter. Returns the animation id upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginOverrideFrameDuration(int animationId, float duration);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginOverrideFrameDurationD(double animationId, double duration);
	/*
		Override the duration of all frames with the `duration` value. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginOverrideFrameDurationName(IntPtr path, float duration);
	/*
		Pause the current animation referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPauseAnimation(int animationId);
	/*
		Pause the current animation referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPauseAnimationName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPauseAnimationNameD(IntPtr path);
	/*
		Plays the `Chroma` animation. This will load the animation, if not loaded 
		previously. Returns the animation id upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginPlayAnimation(int animationId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayAnimationD(double animationId);
	/*
		`PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off` starting at the `frameId`.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationFrame(int animationId, int frameId, bool loop);
	/*
		`PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off` starting at the `frameId`.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationFrameName(IntPtr path, int frameId, bool loop);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayAnimationFrameNameD(IntPtr path, double frameId, double loop);
	/*
		`PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		The method will play the animation given the `animationId` with looping 
		`on` or `off`.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationLoop(int animationId, bool loop);
	/*
		`PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will play with looping `on` or `off`.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayAnimationName(IntPtr path, bool loop);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayAnimationNameD(IntPtr path, double loop);
	/*
		`PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will play with looping `on` or `off`.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPlayComposite(IntPtr name, bool loop);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPlayCompositeD(IntPtr name, double loop);
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Returns the animation id upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginPreviewFrame(int animationId, int frameIndex);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginPreviewFrameD(double animationId, double frameIndex);
	/*
		Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		Animaton is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginPreviewFrameName(IntPtr path, int frameIndex);
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReduceFrames(int animationId, int n);
	/*
		Reduce the frames of the animation by removing every nth element. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReduceFramesName(IntPtr path, int n);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginReduceFramesNameD(IntPtr path, double n);
	/*
		Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginResetAnimation(int animationId);
	/*
		Resume the animation with loop `ON` or `OFF` referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginResumeAnimation(int animationId, bool loop);
	/*
		Resume the animation with loop `ON` or `OFF` referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginResumeAnimationName(IntPtr path, bool loop);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginResumeAnimationNameD(IntPtr path, double loop);
	/*
		Reverse the animation frame order of the `Chroma` animation. Returns the 
		animation id upon success. Returns -1 upon failure. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginReverse(int animationId);
	/*
		Reverse the animation frame order of the `Chroma` animation. Animation is 
		referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReverseAllFrames(int animationId);
	/*
		Reverse the animation frame order of the `Chroma` animation. Animation is 
		referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginReverseAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginReverseAllFramesNameD(IntPtr path);
	/*
		Save the animation referenced by id to the path specified.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSaveAnimation(int animationId, IntPtr path);
	/*
		Save the named animation to the target path specified.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSaveAnimationName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet1DColor(int animationId, int frameId, int led, int color);
	/*
		Set the animation color for a frame given the `1D` `led`. The `led` should 
		be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet1DColorName(IntPtr path, int frameId, int led, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSet1DColorNameD(IntPtr path, double frameId, double led, double color);
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet2DColor(int animationId, int frameId, int row, int column, int color);
	/*
		Set the animation color for a frame given the `2D` `row` and `column`. The 
		`row` should be greater than or equal to 0 and less than the `MaxRow`. 
		The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		The animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSet2DColorName(IntPtr path, int frameId, int row, int column, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSet2DColorNameD(IntPtr path, double frameId, double rowColumnIndex, double color);
	/*
		When custom color is set, the custom key mode will be used. The animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomColorAllFrames(int animationId);
	/*
		When custom color is set, the custom key mode will be used. The animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomColorAllFramesName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetChromaCustomColorAllFramesNameD(IntPtr path);
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomFlag(int animationId, bool flag);
	/*
		Set the Chroma custom key color flag on all frames. `True` changes the layout 
		from grid to key. `True` changes the layout from key to grid. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetChromaCustomFlagName(IntPtr path, bool flag);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetChromaCustomFlagNameD(IntPtr path, double flag);
	/*
		Set the current frame of the animation referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetCurrentFrame(int animationId, int frameId);
	/*
		Set the current frame of the animation referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetCurrentFrameName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetCurrentFrameNameD(IntPtr path, double frameId);
	/*
		Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		the animation id upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSetDevice(int animationId, int deviceType, int device);
	/*
		SetEffect will display the referenced effect id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginSetEffect(System.Guid effectId);
	/*
		Set animation key to a static color for the given frame.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColor(int animationId, int frameId, int rzkey, int color);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFrames(int animationId, int rzkey, int color);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFramesName(IntPtr path, int rzkey, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorAllFramesNameD(IntPtr path, double rzkey, double color);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue);
	/*
		Set the key to the specified key color for all frames. Animation is referenced 
		by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorAllFramesRGBName(IntPtr path, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorAllFramesRGBNameD(IntPtr path, double rzkey, double red, double green, double blue);
	/*
		Set animation key to a static color for the given frame.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorName(IntPtr path, int frameId, int rzkey, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorNameD(IntPtr path, double frameId, double rzkey, double color);
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	/*
		Set the key to the specified key color for the specified frame. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color);
	/*
		Set animation key to a static color for the given frame if the existing 
		color is not already black.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColorName(IntPtr path, int frameId, int rzkey, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyNonZeroColorNameD(IntPtr path, double frameId, double rzkey, double color);
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	/*
		Set the key to the specified key color for the specified frame where color 
		is not black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyNonZeroColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyNonZeroColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for all frames. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorAllFramesRGBName(IntPtr path, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame. Animation 
		is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames if the existing 
		color is not already black. Reference animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame if 
		the existing color is not already black. Reference animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is not black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysNonZeroColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for all frames where the 
		color is black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorAllFramesRGBName(IntPtr path, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set an array of animation keys to a static color for the given frame where 
		the color is black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeysZeroColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColor(int animationId, int frameId, int rzkey, int color);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColorName(IntPtr path, int frameId, int rzkey, int color);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyZeroColorNameD(IntPtr path, double frameId, double rzkey, double color);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
	/*
		Set animation key to a static color for the given frame where the color 
		is black. Animation is referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetKeyZeroColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSetKeyZeroColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
	/*
		Invokes the setup for a debug logging callback so that `stdout` is redirected 
		to the callback. This is used by `Unity` so that debug messages can appear 
		in the console window.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSetLogDelegate(DebugLogPtr fp);
	/*
		`PluginStopAll` will automatically stop all animations that are playing.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopAll();
	/*
		Stops animation playback if in progress. Returns the animation id upon success. 
		Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginStopAnimation(int animationId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopAnimationD(double animationId);
	/*
		`PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		The named `.chroma` animation file will be automatically opened. The animation 
		will stop if playing.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopAnimationName(IntPtr path);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopAnimationNameD(IntPtr path);
	/*
		`PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		If any animation is playing for the `deviceType` and `device` combination, 
		it will be stopped.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopAnimationType(int deviceType, int device);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopAnimationTypeD(double deviceType, double device);
	/*
		`PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		The named animation files for the `.chroma` set will be automatically opened. 
		The set of animations will be stopped if playing.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginStopComposite(IntPtr name);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginStopCompositeD(IntPtr name);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black. Source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Subtract the source color from the target color for all frames where the 
		target color is not black starting at offset for the length of the source. 
		Source and target are referenced by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Subtract the source color from the target where color is not black for the 
		source frame and target offset frame, reference source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames. Reference source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black for all frames starting at the target offset for the length of 
		the source. Reference source and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
	/*
		Subtract the source color from the target color where the target color is 
		not black from the source frame to the target offset frame. Reference source 
		and target by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginSubtractNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginSubtractNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimEndFrames(int animationId, int lastFrameId);
	/*
		Trim the end of the animation. The length of the animation will be the lastFrameId 
		+ 1. Reference the animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimEndFramesName(IntPtr path, int lastFrameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginTrimEndFramesNameD(IntPtr path, double lastFrameId);
	/*
		Remove the frame from the animation. Reference animation by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimFrame(int animationId, int frameId);
	/*
		Remove the frame from the animation. Reference animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimFrameName(IntPtr path, int frameId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginTrimFrameNameD(IntPtr path, double frameId);
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimStartFrames(int animationId, int numberOfFrames);
	/*
		Trim the start of the animation starting at frame 0 for the number of frames. 
		Reference the animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginTrimStartFramesName(IntPtr path, int numberOfFrames);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginTrimStartFramesNameD(IntPtr path, double numberOfFrames);
	/*
		Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns -1 upon failure.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginUninit();
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginUninitD();
	/*
		Unloads `Chroma` effects to free up resources. Returns the animation id 
		upon success. Returns -1 upon failure. Reference the animation by id.
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginUnloadAnimation(int animationId);
	/*
		D suffix for limited data types.
	*/
	[DllImport(DLL_NAME)]
	private static extern double PluginUnloadAnimationD(double animationId);
	/*
		Unload the animation effects. Reference the animation by name.
	*/
	[DllImport(DLL_NAME)]
	private static extern void PluginUnloadAnimationName(IntPtr path);
	/*
		Unload the the composite set of animation effects. Reference the animation 
		by name.
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
	*/
	[DllImport(DLL_NAME)]
	private static extern int PluginUpdateFrame(int animationId, int frameIndex, float duration, int[] colors, int length);
#endregion
